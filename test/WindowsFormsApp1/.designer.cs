namespace ChuaDongHP
{
    partial class Form1
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
            this.dtgvChuaDongHP = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienPhaiDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbNamHoc = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.lbHocKy = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btThoat = new System.Windows.Forms.Button();
            this.btInPhieu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuaDongHP)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvChuaDongHP
            // 
            this.dtgvChuaDongHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChuaDongHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MSSV,
            this.SoTienDangKy,
            this.SoTienPhaiDong,
            this.SoTienConLai});
            this.dtgvChuaDongHP.Location = new System.Drawing.Point(0, 13);
            this.dtgvChuaDongHP.Name = "dtgvChuaDongHP";
            this.dtgvChuaDongHP.RowHeadersWidth = 51;
            this.dtgvChuaDongHP.RowTemplate.Height = 24;
            this.dtgvChuaDongHP.Size = new System.Drawing.Size(1311, 156);
            this.dtgvChuaDongHP.TabIndex = 11;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 125;
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "Mã số sinh viên";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 300;
            // 
            // SoTienDangKy
            // 
            this.SoTienDangKy.HeaderText = "Số tiền đăng ký";
            this.SoTienDangKy.MinimumWidth = 6;
            this.SoTienDangKy.Name = "SoTienDangKy";
            this.SoTienDangKy.Width = 300;
            // 
            // SoTienPhaiDong
            // 
            this.SoTienPhaiDong.HeaderText = "Số tiền phải đóng";
            this.SoTienPhaiDong.MinimumWidth = 6;
            this.SoTienPhaiDong.Name = "SoTienPhaiDong";
            this.SoTienPhaiDong.Width = 300;
            // 
            // SoTienConLai
            // 
            this.SoTienConLai.HeaderText = "Số tiền còn lại";
            this.SoTienConLai.MinimumWidth = 6;
            this.SoTienConLai.Name = "SoTienConLai";
            this.SoTienConLai.Width = 300;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lbNamHoc);
            this.panel1.Controls.Add(this.cbHocKy);
            this.panel1.Controls.Add(this.lbHocKy);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 61);
            this.panel1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(836, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 30);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "2020";
            // 
            // lbNamHoc
            // 
            this.lbNamHoc.AutoSize = true;
            this.lbNamHoc.BackColor = System.Drawing.Color.Silver;
            this.lbNamHoc.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamHoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNamHoc.Location = new System.Drawing.Point(677, 8);
            this.lbNamHoc.Name = "lbNamHoc";
            this.lbNamHoc.Size = new System.Drawing.Size(153, 33);
            this.lbNamHoc.TabIndex = 14;
            this.lbNamHoc.Text = "Năm học :";
            // 
            // cbHocKy
            // 
            this.cbHocKy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Items.AddRange(new object[] {
            "Học kỳ I",
            "Học Kỳ II"});
            this.cbHocKy.Location = new System.Drawing.Point(471, 8);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(164, 32);
            this.cbHocKy.TabIndex = 13;
            this.cbHocKy.Text = "Chọn học kỳ";
            this.cbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbHocKy_SelectedIndexChanged);
            // 
            // lbHocKy
            // 
            this.lbHocKy.AutoSize = true;
            this.lbHocKy.BackColor = System.Drawing.Color.Silver;
            this.lbHocKy.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHocKy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbHocKy.Location = new System.Drawing.Point(336, 11);
            this.lbHocKy.Name = "lbHocKy";
            this.lbHocKy.Size = new System.Drawing.Size(118, 33);
            this.lbHocKy.TabIndex = 12;
            this.lbHocKy.Text = "Học kỳ:";
            this.lbHocKy.Click += new System.EventHandler(this.lbHocKy_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvChuaDongHP);
            this.panel2.Location = new System.Drawing.Point(12, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1314, 182);
            this.panel2.TabIndex = 13;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btThoat.Location = new System.Drawing.Point(471, 3);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(143, 53);
            this.btThoat.TabIndex = 14;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btInPhieu
            // 
            this.btInPhieu.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInPhieu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btInPhieu.Location = new System.Drawing.Point(642, 3);
            this.btInPhieu.Name = "btInPhieu";
            this.btInPhieu.Size = new System.Drawing.Size(143, 53);
            this.btInPhieu.TabIndex = 15;
            this.btInPhieu.Text = "In Phiếu";
            this.btInPhieu.UseVisualStyleBackColor = true;
            this.btInPhieu.Click += new System.EventHandler(this.btInPhieu_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btThoat);
            this.panel3.Controls.Add(this.btInPhieu);
            this.panel3.Location = new System.Drawing.Point(12, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1311, 63);
            this.panel3.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 605);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuaDongHP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvChuaDongHP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbNamHoc;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Label lbHocKy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btInPhieu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienPhaiDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienConLai;
    }
}

