namespace NhapCThoc
{
    partial class fNhapCTHoc
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
            this.btThemCTHoc = new System.Windows.Forms.Button();
            this.btSuaCTHoc = new System.Windows.Forms.Button();
            this.btXoaCTHoc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.labelKhoa = new System.Windows.Forms.Label();
            this.tbMaCTHoc = new System.Windows.Forms.TextBox();
            this.lbMaCTHoc = new System.Windows.Forms.Label();
            this.cbbNganh = new System.Windows.Forms.ComboBox();
            this.Nganh = new System.Windows.Forms.Label();
            this.dgvCTHoc = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbHocKi = new System.Windows.Forms.TextBox();
            this.lbHocKi = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.tbMaMonHoc = new System.Windows.Forms.TextBox();
            this.lbMaMonHoc = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btThemCTHoc
            // 
            this.btThemCTHoc.Location = new System.Drawing.Point(206, 673);
            this.btThemCTHoc.Name = "btThemCTHoc";
            this.btThemCTHoc.Size = new System.Drawing.Size(102, 42);
            this.btThemCTHoc.TabIndex = 1;
            this.btThemCTHoc.Text = "Thêm";
            this.btThemCTHoc.UseVisualStyleBackColor = true;
            this.btThemCTHoc.Click += new System.EventHandler(this.BtThemCTHoc_Click);
            // 
            // btSuaCTHoc
            // 
            this.btSuaCTHoc.Location = new System.Drawing.Point(508, 673);
            this.btSuaCTHoc.Name = "btSuaCTHoc";
            this.btSuaCTHoc.Size = new System.Drawing.Size(102, 42);
            this.btSuaCTHoc.TabIndex = 2;
            this.btSuaCTHoc.Text = "Sửa";
            this.btSuaCTHoc.UseVisualStyleBackColor = true;
            this.btSuaCTHoc.Click += new System.EventHandler(this.BtSuaCTHoc_Click);
            // 
            // btXoaCTHoc
            // 
            this.btXoaCTHoc.Location = new System.Drawing.Point(790, 673);
            this.btXoaCTHoc.Name = "btXoaCTHoc";
            this.btXoaCTHoc.Size = new System.Drawing.Size(119, 42);
            this.btXoaCTHoc.TabIndex = 3;
            this.btXoaCTHoc.Text = "Xóa";
            this.btXoaCTHoc.UseVisualStyleBackColor = true;
            this.btXoaCTHoc.Click += new System.EventHandler(this.BtXoaCTHoc_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbKhoa);
            this.panel2.Controls.Add(this.labelKhoa);
            this.panel2.Controls.Add(this.tbMaCTHoc);
            this.panel2.Controls.Add(this.lbMaCTHoc);
            this.panel2.Location = new System.Drawing.Point(3, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 50);
            this.panel2.TabIndex = 0;
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.AllowDrop = true;
            this.cbbKhoa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(373, 10);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(193, 23);
            this.cbbKhoa.TabIndex = 2;
            this.cbbKhoa.Text = "Chọn khoa";
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.CbbKhoa_SelectedIndexChanged);
            // 
            // labelKhoa
            // 
            this.labelKhoa.AutoSize = true;
            this.labelKhoa.Location = new System.Drawing.Point(302, 10);
            this.labelKhoa.Name = "labelKhoa";
            this.labelKhoa.Size = new System.Drawing.Size(56, 19);
            this.labelKhoa.TabIndex = 2;
            this.labelKhoa.Text = "Khoa:";
            // 
            // tbMaCTHoc
            // 
            this.tbMaCTHoc.Location = new System.Drawing.Point(127, 7);
            this.tbMaCTHoc.Name = "tbMaCTHoc";
            this.tbMaCTHoc.ReadOnly = true;
            this.tbMaCTHoc.Size = new System.Drawing.Size(88, 26);
            this.tbMaCTHoc.TabIndex = 1;
            this.tbMaCTHoc.TextChanged += new System.EventHandler(this.TbMaCTHoc_TextChanged);
            // 
            // lbMaCTHoc
            // 
            this.lbMaCTHoc.AutoSize = true;
            this.lbMaCTHoc.Location = new System.Drawing.Point(3, 10);
            this.lbMaCTHoc.Name = "lbMaCTHoc";
            this.lbMaCTHoc.Size = new System.Drawing.Size(92, 19);
            this.lbMaCTHoc.TabIndex = 0;
            this.lbMaCTHoc.Text = "Mã CT Học";
            // 
            // cbbNganh
            // 
            this.cbbNganh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNganh.FormattingEnabled = true;
            this.cbbNganh.Location = new System.Drawing.Point(127, 10);
            this.cbbNganh.Name = "cbbNganh";
            this.cbbNganh.Size = new System.Drawing.Size(139, 23);
            this.cbbNganh.TabIndex = 1;
            this.cbbNganh.Text = "Chọn ngành học";
            this.cbbNganh.SelectedIndexChanged += new System.EventHandler(this.CbbNganh_SelectedIndexChanged);
            // 
            // Nganh
            // 
            this.Nganh.AutoSize = true;
            this.Nganh.Location = new System.Drawing.Point(3, 10);
            this.Nganh.Name = "Nganh";
            this.Nganh.Size = new System.Drawing.Size(99, 19);
            this.Nganh.TabIndex = 0;
            this.Nganh.Text = "Ngành học:";
            // 
            // dgvCTHoc
            // 
            this.dgvCTHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHoc.Location = new System.Drawing.Point(3, 548);
            this.dgvCTHoc.Name = "dgvCTHoc";
            this.dgvCTHoc.RowHeadersWidth = 62;
            this.dgvCTHoc.RowTemplate.Height = 28;
            this.dgvCTHoc.Size = new System.Drawing.Size(1132, 119);
            this.dgvCTHoc.TabIndex = 5;
            this.dgvCTHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbHocKi);
            this.panel1.Controls.Add(this.lbHocKi);
            this.panel1.Controls.Add(this.cbbNganh);
            this.panel1.Controls.Add(this.Nganh);
            this.panel1.Location = new System.Drawing.Point(3, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 50);
            this.panel1.TabIndex = 6;
            // 
            // tbHocKi
            // 
            this.tbHocKi.Location = new System.Drawing.Point(373, 7);
            this.tbHocKi.Name = "tbHocKi";
            this.tbHocKi.Size = new System.Drawing.Size(62, 26);
            this.tbHocKi.TabIndex = 3;
            // 
            // lbHocKi
            // 
            this.lbHocKi.AutoSize = true;
            this.lbHocKi.Location = new System.Drawing.Point(302, 10);
            this.lbHocKi.Name = "lbHocKi";
            this.lbHocKi.Size = new System.Drawing.Size(57, 19);
            this.lbHocKi.TabIndex = 2;
            this.lbHocKi.Text = "Học kì";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbGhiChu);
            this.panel3.Controls.Add(this.lbGhiChu);
            this.panel3.Controls.Add(this.tbMaMonHoc);
            this.panel3.Controls.Add(this.lbMaMonHoc);
            this.panel3.Location = new System.Drawing.Point(57, 419);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1132, 50);
            this.panel3.TabIndex = 7;
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(766, 7);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(356, 26);
            this.tbGhiChu.TabIndex = 3;
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(583, 10);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(71, 19);
            this.lbGhiChu.TabIndex = 2;
            this.lbGhiChu.Text = "Ghi Chú";
            this.lbGhiChu.Click += new System.EventHandler(this.Label2_Click);
            // 
            // tbMaMonHoc
            // 
            this.tbMaMonHoc.Location = new System.Drawing.Point(166, 7);
            this.tbMaMonHoc.Name = "tbMaMonHoc";
            this.tbMaMonHoc.Size = new System.Drawing.Size(307, 26);
            this.tbMaMonHoc.TabIndex = 1;
            // 
            // lbMaMonHoc
            // 
            this.lbMaMonHoc.AutoSize = true;
            this.lbMaMonHoc.Location = new System.Drawing.Point(3, 10);
            this.lbMaMonHoc.Name = "lbMaMonHoc";
            this.lbMaMonHoc.Size = new System.Drawing.Size(103, 19);
            this.lbMaMonHoc.TabIndex = 0;
            this.lbMaMonHoc.Text = "Mã Môn Học";
            // 
            // fNhapCTHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 741);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCTHoc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btXoaCTHoc);
            this.Controls.Add(this.btSuaCTHoc);
            this.Controls.Add(this.btThemCTHoc);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "fNhapCTHoc";
            this.Text = "Nhập chương trình học";
            this.Load += new System.EventHandler(this.FNhapCTHoc_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btThemCTHoc;
        private System.Windows.Forms.Button btSuaCTHoc;
        private System.Windows.Forms.Button btXoaCTHoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label labelKhoa;
        private System.Windows.Forms.ComboBox cbbNganh;
        private System.Windows.Forms.Label Nganh;
        private System.Windows.Forms.DataGridView dgvCTHoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbMaCTHoc;
        private System.Windows.Forms.Label lbMaCTHoc;
        private System.Windows.Forms.TextBox tbHocKi;
        private System.Windows.Forms.Label lbHocKi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.TextBox tbMaMonHoc;
        private System.Windows.Forms.Label lbMaMonHoc;
    }
}

