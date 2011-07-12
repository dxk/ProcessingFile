namespace ProecFile
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCheckFile = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.tbM = new System.Windows.Forms.TextBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_E = new System.Windows.Forms.Label();
            this.lbl_F = new System.Windows.Forms.Label();
            this.lbl_S = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_over_2 = new System.Windows.Forms.TextBox();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Execute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fetch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckFile
            // 
            this.btnCheckFile.Location = new System.Drawing.Point(13, 5);
            this.btnCheckFile.Name = "btnCheckFile";
            this.btnCheckFile.Size = new System.Drawing.Size(75, 23);
            this.btnCheckFile.TabIndex = 0;
            this.btnCheckFile.Text = "选择文件";
            this.btnCheckFile.UseVisualStyleBackColor = true;
            this.btnCheckFile.Click += new System.EventHandler(this.btnCheckFile_Click);
            // 
            // btnRead
            // 
            this.btnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRead.Location = new System.Drawing.Point(694, 5);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "读取";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // tbM
            // 
            this.tbM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbM.Location = new System.Drawing.Point(94, 6);
            this.tbM.Name = "tbM";
            this.tbM.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbM.Size = new System.Drawing.Size(594, 21);
            this.tbM.TabIndex = 3;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Execute,
            this.Fetch,
            this.Total,
            this.Text});
            this.dgv1.Location = new System.Drawing.Point(12, 34);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(757, 198);
            this.dgv1.TabIndex = 6;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            this.dgv1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbl_S);
            this.panel1.Controls.Add(this.lbl_F);
            this.panel1.Controls.Add(this.lbl_E);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 23);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "统计:";
            // 
            // lbl_E
            // 
            this.lbl_E.AutoSize = true;
            this.lbl_E.Location = new System.Drawing.Point(123, 5);
            this.lbl_E.Name = "lbl_E";
            this.lbl_E.Size = new System.Drawing.Size(41, 12);
            this.lbl_E.TabIndex = 0;
            this.lbl_E.Text = "label1";
            // 
            // lbl_F
            // 
            this.lbl_F.AutoSize = true;
            this.lbl_F.Location = new System.Drawing.Point(226, 5);
            this.lbl_F.Name = "lbl_F";
            this.lbl_F.Size = new System.Drawing.Size(41, 12);
            this.lbl_F.TabIndex = 0;
            this.lbl_F.Text = "label1";
            // 
            // lbl_S
            // 
            this.lbl_S.AutoSize = true;
            this.lbl_S.Location = new System.Drawing.Point(329, 5);
            this.lbl_S.Name = "lbl_S";
            this.lbl_S.Size = new System.Drawing.Size(41, 12);
            this.lbl_S.TabIndex = 0;
            this.lbl_S.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tb_over_2);
            this.groupBox1.Location = new System.Drawing.Point(13, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 289);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OVERALL";
            // 
            // tb_over_2
            // 
            this.tb_over_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_over_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_over_2.Location = new System.Drawing.Point(6, 14);
            this.tb_over_2.Multiline = true;
            this.tb_over_2.Name = "tb_over_2";
            this.tb_over_2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_over_2.Size = new System.Drawing.Size(744, 269);
            this.tb_over_2.TabIndex = 0;
            this.tb_over_2.DoubleClick += new System.EventHandler(this.tb_over_2_DoubleClick);
            // 
            // No
            // 
            this.No.DataPropertyName = "no";
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // Execute
            // 
            this.Execute.DataPropertyName = "ex";
            this.Execute.HeaderText = "Execute";
            this.Execute.Name = "Execute";
            this.Execute.ReadOnly = true;
            // 
            // Fetch
            // 
            this.Fetch.DataPropertyName = "fe";
            this.Fetch.HeaderText = "Fetch";
            this.Fetch.Name = "Fetch";
            this.Fetch.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "sum";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Text
            // 
            this.Text.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Text.DataPropertyName = "str";
            this.Text.HeaderText = "Text";
            this.Text.Name = "Text";
            this.Text.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.tbM);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnCheckFile);
            this.Name = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckFile;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_S;
        private System.Windows.Forms.Label lbl_F;
        private System.Windows.Forms.Label lbl_E;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_over_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Execute;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fetch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Text;
    }
}