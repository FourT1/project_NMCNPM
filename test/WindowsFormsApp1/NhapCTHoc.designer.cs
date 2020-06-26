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
            this.btTraCuuCTHoc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.labelKhoa = new System.Windows.Forms.Label();
            this.cbbNganh = new System.Windows.Forms.ComboBox();
            this.Nganh = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btThemCTHoc
            // 
            this.btThemCTHoc.Location = new System.Drawing.Point(227, 384);
            this.btThemCTHoc.Name = "btThemCTHoc";
            this.btThemCTHoc.Size = new System.Drawing.Size(102, 42);
            this.btThemCTHoc.TabIndex = 1;
            this.btThemCTHoc.Text = "Thêm";
            this.btThemCTHoc.UseVisualStyleBackColor = true;
            // 
            // btSuaCTHoc
            // 
            this.btSuaCTHoc.Location = new System.Drawing.Point(505, 384);
            this.btSuaCTHoc.Name = "btSuaCTHoc";
            this.btSuaCTHoc.Size = new System.Drawing.Size(102, 42);
            this.btSuaCTHoc.TabIndex = 2;
            this.btSuaCTHoc.Text = "Sửa";
            this.btSuaCTHoc.UseVisualStyleBackColor = true;
            // 
            // btTraCuuCTHoc
            // 
            this.btTraCuuCTHoc.Location = new System.Drawing.Point(762, 384);
            this.btTraCuuCTHoc.Name = "btTraCuuCTHoc";
            this.btTraCuuCTHoc.Size = new System.Drawing.Size(119, 42);
            this.btTraCuuCTHoc.TabIndex = 3;
            this.btTraCuuCTHoc.Text = "Tra Cứu";
            this.btTraCuuCTHoc.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbKhoa);
            this.panel2.Controls.Add(this.labelKhoa);
            this.panel2.Controls.Add(this.cbbNganh);
            this.panel2.Controls.Add(this.Nganh);
            this.panel2.Location = new System.Drawing.Point(3, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 50);
            this.panel2.TabIndex = 0;
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(722, 9);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(421, 30);
            this.cbbKhoa.TabIndex = 2;
            this.cbbKhoa.Text = "Chọn khoa";
            // 
            // labelKhoa
            // 
            this.labelKhoa.AutoSize = true;
            this.labelKhoa.Location = new System.Drawing.Point(636, 11);
            this.labelKhoa.Name = "labelKhoa";
            this.labelKhoa.Size = new System.Drawing.Size(80, 29);
            this.labelKhoa.TabIndex = 2;
            this.labelKhoa.Text = "Khoa:";
            // 
            // cbbNganh
            // 
            this.cbbNganh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNganh.FormattingEnabled = true;
            this.cbbNganh.Location = new System.Drawing.Point(154, 10);
            this.cbbNganh.Name = "cbbNganh";
            this.cbbNganh.Size = new System.Drawing.Size(359, 30);
            this.cbbNganh.TabIndex = 1;
            this.cbbNganh.Text = "Chọn ngành học";
            // 
            // Nganh
            // 
            this.Nganh.AutoSize = true;
            this.Nganh.Location = new System.Drawing.Point(3, 10);
            this.Nganh.Name = "Nganh";
            this.Nganh.Size = new System.Drawing.Size(145, 29);
            this.Nganh.TabIndex = 0;
            this.Nganh.Text = "Ngành học:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.HocKi,
            this.MaMonHoc,
            this.GhiChu});
            this.dataGridView1.Location = new System.Drawing.Point(3, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1157, 310);
            this.dataGridView1.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ChuongTrinhHoc";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 150;
            // 
            // HocKi
            // 
            this.HocKi.DataPropertyName = "ChuongTrinhHoc";
            this.HocKi.HeaderText = "Học Kì";
            this.HocKi.MinimumWidth = 8;
            this.HocKi.Name = "HocKi";
            this.HocKi.Width = 150;
            // 
            // MaMonHoc
            // 
            this.MaMonHoc.HeaderText = "Mã Môn học";
            this.MaMonHoc.MinimumWidth = 8;
            this.MaMonHoc.Name = "MaMonHoc";
            this.MaMonHoc.Width = 350;
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 8;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 600;
            // 
            // fNhapCTHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 438);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btTraCuuCTHoc);
            this.Controls.Add(this.btSuaCTHoc);
            this.Controls.Add(this.btThemCTHoc);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "fNhapCTHoc";
            this.Text = "Nhập chương trình học";
            this.Load += new System.EventHandler(this.FNhapCTHoc_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btThemCTHoc;
        private System.Windows.Forms.Button btSuaCTHoc;
        private System.Windows.Forms.Button btTraCuuCTHoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label labelKhoa;
        private System.Windows.Forms.ComboBox cbbNganh;
        private System.Windows.Forms.Label Nganh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}

