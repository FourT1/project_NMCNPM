namespace QuanLyThuHocPhi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btThoat = new System.Windows.Forms.Button();
            this.btInPhieu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.lbSTT = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DomainUpDown();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.lbNamHoc = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.lbHocKy = new System.Windows.Forms.Label();
            this.lbSoTienDangKy = new System.Windows.Forms.Label();
            this.txtSoTienDangKy = new System.Windows.Forms.TextBox();
            this.lbSoTienPhaiDong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbNamHoc);
            this.panel1.Controls.Add(this.lbNamHoc);
            this.panel1.Controls.Add(this.cbHocKy);
            this.panel1.Controls.Add(this.lbHocKy);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 50);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btThoat.Location = new System.Drawing.Point(457, 415);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(143, 53);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btInPhieu
            // 
            this.btInPhieu.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInPhieu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btInPhieu.Location = new System.Drawing.Point(643, 415);
            this.btInPhieu.Name = "btInPhieu";
            this.btInPhieu.Size = new System.Drawing.Size(143, 53);
            this.btInPhieu.TabIndex = 5;
            this.btInPhieu.Text = "In Phiếu";
            this.btInPhieu.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbSoTienPhaiDong);
            this.panel2.Controls.Add(this.txtSoTienDangKy);
            this.panel2.Controls.Add(this.lbSoTienDangKy);
            this.panel2.Controls.Add(this.txtMSSV);
            this.panel2.Controls.Add(this.lbMSSV);
            this.panel2.Controls.Add(this.lbSTT);
            this.panel2.Controls.Add(this.STT);
            this.panel2.Location = new System.Drawing.Point(12, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1254, 191);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.Location = new System.Drawing.Point(104, 30);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(229, 30);
            this.txtMSSV.TabIndex = 4;
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSSV.ForeColor = System.Drawing.Color.Black;
            this.lbMSSV.Location = new System.Drawing.Point(147, 4);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(148, 25);
            this.lbMSSV.TabIndex = 3;
            this.lbMSSV.Text = "Mã số sinh viên";
            // 
            // lbSTT
            // 
            this.lbSTT.AutoSize = true;
            this.lbSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSTT.ForeColor = System.Drawing.Color.Black;
            this.lbSTT.Location = new System.Drawing.Point(3, 4);
            this.lbSTT.Name = "lbSTT";
            this.lbSTT.Size = new System.Drawing.Size(52, 25);
            this.lbSTT.TabIndex = 2;
            this.lbSTT.Text = "STT";
            // 
            // STT
            // 
            this.STT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.Location = new System.Drawing.Point(0, 32);
            this.STT.Name = "STT";
            this.STT.Size = new System.Drawing.Size(55, 30);
            this.STT.TabIndex = 0;
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Items.AddRange(new object[] {
            "ssd"});
            this.cbNamHoc.Location = new System.Drawing.Point(584, 9);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(229, 36);
            this.cbNamHoc.TabIndex = 5;
            this.cbNamHoc.Text = "Chọn năm học";
            // 
            // lbNamHoc
            // 
            this.lbNamHoc.AutoSize = true;
            this.lbNamHoc.BackColor = System.Drawing.Color.Silver;
            this.lbNamHoc.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamHoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNamHoc.Location = new System.Drawing.Point(425, 9);
            this.lbNamHoc.Name = "lbNamHoc";
            this.lbNamHoc.Size = new System.Drawing.Size(153, 33);
            this.lbNamHoc.TabIndex = 4;
            this.lbNamHoc.Text = "Năm học :";
            // 
            // cbHocKy
            // 
            this.cbHocKy.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Items.AddRange(new object[] {
            "Học kỳ I"});
            this.cbHocKy.Location = new System.Drawing.Point(140, 9);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(229, 36);
            this.cbHocKy.TabIndex = 3;
            this.cbHocKy.Text = "Chọn học kỳ";
            // 
            // lbHocKy
            // 
            this.lbHocKy.AutoSize = true;
            this.lbHocKy.BackColor = System.Drawing.Color.Silver;
            this.lbHocKy.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHocKy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbHocKy.Location = new System.Drawing.Point(16, 9);
            this.lbHocKy.Name = "lbHocKy";
            this.lbHocKy.Size = new System.Drawing.Size(118, 33);
            this.lbHocKy.TabIndex = 2;
            this.lbHocKy.Text = "Học kỳ:";
            // 
            // lbSoTienDangKy
            // 
            this.lbSoTienDangKy.AutoSize = true;
            this.lbSoTienDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTienDangKy.ForeColor = System.Drawing.Color.Black;
            this.lbSoTienDangKy.Location = new System.Drawing.Point(441, 4);
            this.lbSoTienDangKy.Name = "lbSoTienDangKy";
            this.lbSoTienDangKy.Size = new System.Drawing.Size(147, 25);
            this.lbSoTienDangKy.TabIndex = 5;
            this.lbSoTienDangKy.Text = "Số tiền đăng ký";
            this.lbSoTienDangKy.Click += new System.EventHandler(this.lbSoTienDangKy_Click);
            // 
            // txtSoTienDangKy
            // 
            this.txtSoTienDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienDangKy.Location = new System.Drawing.Point(399, 32);
            this.txtSoTienDangKy.Name = "txtSoTienDangKy";
            this.txtSoTienDangKy.Size = new System.Drawing.Size(229, 30);
            this.txtSoTienDangKy.TabIndex = 6;
            // 
            // lbSoTienPhaiDong
            // 
            this.lbSoTienPhaiDong.AutoSize = true;
            this.lbSoTienPhaiDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTienPhaiDong.ForeColor = System.Drawing.Color.Black;
            this.lbSoTienPhaiDong.Location = new System.Drawing.Point(710, 4);
            this.lbSoTienPhaiDong.Name = "lbSoTienPhaiDong";
            this.lbSoTienPhaiDong.Size = new System.Drawing.Size(164, 25);
            this.lbSoTienPhaiDong.TabIndex = 7;
            this.lbSoTienPhaiDong.Text = "Số tiền phải đóng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1013, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Số tiền còn lại";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 480);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btInPhieu);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Name = "Form1";
            this.Text = "DANH SÁCH SINH VIÊN CHƯA HOÀN THÀNH VIỆC ĐÓNG HỌC PHÍ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.Label lbNamHoc;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Label lbHocKy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Label lbSTT;
        private System.Windows.Forms.DomainUpDown STT;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btInPhieu;
        private System.Windows.Forms.Label lbSoTienDangKy;
        private System.Windows.Forms.TextBox txtSoTienDangKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSoTienPhaiDong;
    }
}

