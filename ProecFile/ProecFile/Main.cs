using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace ProecFile
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //点击选择文件
        private void btnCheckFile_Click(object sender, EventArgs e)
        {
            checkFile(this.tbM);
        }

        //选择文件
        private string checkFile(TextBox obj)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                obj.Text = dlg.FileName;
                return dlg.FileName;
            }
            else
            {
                return "";
            }
        }

        IList<Entity> list;
        decimal all_e = 0, all_f = 0, all_s = 0;
        string RECURSIVE = "";
        //点击读取
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                backdata();
                list = getList();
                if (list != null)
                {
                    dgv1.DataSource = list;
                    statistics(true);
                    fillTb(list.Count);
                }
                else
                {
                    dgv1.DataSource = new List<Entity>();
                    statistics(false);
                    RECURSIVE = "";
                    this.tb_over_2.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("未知错误", "通知：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv1.DataSource = new List<Entity>();
                statistics(false);
                RECURSIVE = "";
                this.tb_over_2.Text = "";
            }
        }

        //填充文本框
        private void fillTb(int count)
        {
            RECURSIVE = "";
            StreamReader sr = new StreamReader(tbM.Text, Encoding.GetEncoding("gbk"), false);
            string line;
            int num = 0;
            bool ifs = false;
            if (sr != null)
            {
                line = sr.ReadLine();
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line.StartsWith("***********************************"))
                    {
                        num++;
                        if (num == count + 2)
                        {
                            ifs = true;
                            break;
                        }
                    }
                }
                while (ifs && line != null)
                {
                    line = sr.ReadLine();
                    if (line.StartsWith("***********************************"))
                        break;
                    RECURSIVE += line + "\r\n";
                }
            }
            this.tb_over_2.Text = RECURSIVE;
        }

        //统计
        private void statistics(bool b)
        {
            if (b)
            {
                this.lbl_E.Text = all_e.ToString();
                this.lbl_F.Text = all_f.ToString();
                this.lbl_S.Text = all_s.ToString() + "(Min:" +
                    ((all_s / 60).ToString().Contains(".") ? (all_s / 60).ToString().Substring(0, (all_s / 60).ToString().IndexOf(".") + 3) : (all_s / 60).ToString()) + ")";
            }
            else
            {
                this.lbl_E.Text = "0";
                this.lbl_F.Text = "0";
                this.lbl_S.Text = "0";
            }
        }

        //每次清零数据
        private void backdata()
        {
            all_e = 0; all_f = 0; all_s = 0;
            RECURSIVE = "";
            list = null;
        }

        //读取
        private IList<Entity> getList()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(tbM.Text, Encoding.GetEncoding("gbk"), false);
                if (sr == null)
                    throw new Exception();
            }
            catch (Exception exe)
            {
                MessageBox.Show("读取文件失败！");
                return null;
            }
            string line;
            int num = 0;
            bool reif = true;

            IList<Entity> list = new List<Entity>();

            #region
            if (sr != null)
            {
                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    if (line.StartsWith("***********************************"))
                    {
                        num++;
                        //
                        #region
                        if (num >= 1)
                        {
                            Entity entity = new Entity();
                            string allstr = "";
                            line = sr.ReadLine();
                            while (line != null && !line.Contains("************************************"))
                            {
                                reif = false;
                                allstr += line + "\r\n";

                                if (line.StartsWith("Execute"))
                                {
                                    //var exstr = line.Substring(26, 10).Trim();
                                    var exstr = line.Substring(line.IndexOf(".") + 3, line.LastIndexOf(".") - line.IndexOf("."));
                                    entity.ex = Convert.ToDecimal(exstr);
                                }

                                if (line.StartsWith("Fetch"))
                                {
                                    //var festr = line.Substring(26, 10).Trim();
                                    var festr = line.Substring(line.IndexOf(".") + 3, line.LastIndexOf(".") - line.IndexOf("."));
                                    entity.fe = Convert.ToDecimal(festr);
                                }

                                line = sr.ReadLine();
                            }

                            entity.str = allstr;
                            entity.sum = entity.ex + entity.fe;
                            entity.no = num - 1;

                            all_e += entity.ex;
                            all_f += entity.fe;
                            all_s += entity.sum;

                            list.Add(entity);
                        }
                        #endregion
                    }
                    if (reif)
                        line = sr.ReadLine();
                }
            }
            #endregion

            //删减优化
            all_e -= list[list.Count - 1].ex;
            all_f -= list[list.Count - 1].fe;
            all_s -= list[list.Count - 1].sum;
            list.RemoveAt(list.Count - 1);
            all_e -= list[list.Count - 1].ex;
            all_f -= list[list.Count - 1].fe;
            all_s -= list[list.Count - 1].sum;
            list.RemoveAt(list.Count - 1);
            list.RemoveAt(0);

            IList<Entity> list_ = list.OrderByDescending(x => x.sum).ToList();

            return list_;
        }

        //Cell单机事件
        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex == 0)
            //    MessageBox.Show("kkk");
        }

        //Cell双击事件
        private void dgv1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    Entity ee = list[e.RowIndex];
                    string si = "************************************************************************************";
                    string text = "";
                    text = si + "\r\n" + ee.str + "\r\n" + si;
                    Clipboard.SetText(text);
                    MessageBox.Show("复制成功！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //文本框双击事件
        private void tb_over_2_DoubleClick(object sender, EventArgs e)
        {
            if (RECURSIVE != "" || RECURSIVE != null)
            {
                string si = "************************************************************************************";
                string text = "";
                text = si + "\r\n" + RECURSIVE + "\r\n" + si;
                Clipboard.SetText(text);
                MessageBox.Show("复制成功！");
            }
        }
    }

    public class Entity
    {
        public Entity() { }

        public Entity(int n, decimal e, decimal f, decimal s, string t)
        {
            no = n;
            ex = e;
            fe = f;
            sum = s;
            str = t;
        }

        public int no { get; set; }
        public decimal ex { get; set; }
        public decimal fe { get; set; }
        public decimal sum { get; set; }
        public string str { get; set; }
    }
}
