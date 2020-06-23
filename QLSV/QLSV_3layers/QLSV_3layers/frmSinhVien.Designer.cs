namespace QLSV_3layers
{
    partial class frmSinhVien
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
            this.rdbpoor = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtQuequan = new System.Windows.Forms.TextBox();
            this.mtbNgaysinh = new System.Windows.Forms.MaskedTextBox();
            this.rbtNam = new System.Windows.Forms.RadioButton();
            this.rbtNu = new System.Windows.Forms.RadioButton();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtObject = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.txtNganh = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbpoor
            // 
            this.rdbpoor.AutoSize = true;
            this.rdbpoor.Location = new System.Drawing.Point(414, 125);
            this.rdbpoor.Name = "rdbpoor";
            this.rdbpoor.Size = new System.Drawing.Size(140, 21);
            this.rdbpoor.TabIndex = 5;
            this.rdbpoor.TabStop = true;
            this.rdbpoor.Text = "vùng sâu vùng xa";
            this.rdbpoor.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ và Tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quê quán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(143, 16);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(242, 22);
            this.txtTen.TabIndex = 1;
            // 
            // txtQuequan
            // 
            this.txtQuequan.Location = new System.Drawing.Point(143, 124);
            this.txtQuequan.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuequan.Name = "txtQuequan";
            this.txtQuequan.Size = new System.Drawing.Size(242, 22);
            this.txtQuequan.TabIndex = 1;
            // 
            // mtbNgaysinh
            // 
            this.mtbNgaysinh.Location = new System.Drawing.Point(143, 53);
            this.mtbNgaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.mtbNgaysinh.Mask = "00/00/0000";
            this.mtbNgaysinh.Name = "mtbNgaysinh";
            this.mtbNgaysinh.Size = new System.Drawing.Size(132, 22);
            this.mtbNgaysinh.TabIndex = 2;
            this.mtbNgaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // rbtNam
            // 
            this.rbtNam.AutoSize = true;
            this.rbtNam.Checked = true;
            this.rbtNam.Location = new System.Drawing.Point(143, 86);
            this.rbtNam.Margin = new System.Windows.Forms.Padding(4);
            this.rbtNam.Name = "rbtNam";
            this.rbtNam.Size = new System.Drawing.Size(58, 21);
            this.rbtNam.TabIndex = 3;
            this.rbtNam.TabStop = true;
            this.rbtNam.Text = "Nam";
            this.rbtNam.UseVisualStyleBackColor = true;
            // 
            // rbtNu
            // 
            this.rbtNu.AutoSize = true;
            this.rbtNu.Location = new System.Drawing.Point(327, 88);
            this.rbtNu.Margin = new System.Windows.Forms.Padding(4);
            this.rbtNu.Name = "rbtNu";
            this.rbtNu.Size = new System.Drawing.Size(47, 21);
            this.rbtNu.TabIndex = 3;
            this.rbtNu.Text = "Nữ";
            this.rbtNu.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(143, 285);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(132, 28);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(385, 285);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(129, 28);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Đối tượng";
            // 
            // txtObject
            // 
            this.txtObject.Location = new System.Drawing.Point(143, 154);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(242, 22);
            this.txtObject.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNganh);
            this.panel1.Controls.Add(this.txtKhoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtObject);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.rdbpoor);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.rbtNu);
            this.panel1.Controls.Add(this.rbtNam);
            this.panel1.Controls.Add(this.mtbNgaysinh);
            this.panel1.Controls.Add(this.txtQuequan);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 368);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ngành";
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(143, 184);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(242, 22);
            this.txtKhoa.TabIndex = 12;
            // 
            // txtNganh
            // 
            this.txtNganh.Location = new System.Drawing.Point(143, 212);
            this.txtNganh.Name = "txtNganh";
            this.txtNganh.Size = new System.Drawing.Size(242, 22);
            this.txtNganh.TabIndex = 13;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 392);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSinhVien";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbpoor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtQuequan;
        private System.Windows.Forms.MaskedTextBox mtbNgaysinh;
        private System.Windows.Forms.RadioButton rbtNam;
        private System.Windows.Forms.RadioButton rbtNu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtObject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNganh;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}