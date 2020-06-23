namespace QuanLyThuHocPhi
{
    partial class register
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
            this.components = new System.ComponentModel.Container();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.tbCMT = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTK = new System.Windows.Forms.GroupBox();
            this.tbCapcha = new System.Windows.Forms.TextBox();
            this.lbCapcha = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCheckPass = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDangki = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grb1.SuspendLayout();
            this.grbTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.tbCMT);
            this.grb1.Controls.Add(this.tbSDT);
            this.grb1.Controls.Add(this.tbTen);
            this.grb1.Controls.Add(this.label3);
            this.grb1.Controls.Add(this.label2);
            this.grb1.Controls.Add(this.label1);
            this.grb1.Location = new System.Drawing.Point(12, 12);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(473, 132);
            this.grb1.TabIndex = 0;
            this.grb1.TabStop = false;
            this.grb1.Text = "Thông tin nhân viên ";
            // 
            // tbCMT
            // 
            this.tbCMT.Location = new System.Drawing.Point(138, 86);
            this.tbCMT.Name = "tbCMT";
            this.tbCMT.Size = new System.Drawing.Size(239, 20);
            this.tbCMT.TabIndex = 5;
            this.tbCMT.Leave += new System.EventHandler(this.tbCMT_Leave);
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(138, 57);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(239, 20);
            this.tbSDT.TabIndex = 4;
            this.tbSDT.Leave += new System.EventHandler(this.tbSDT_Leave);
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(138, 26);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(239, 20);
            this.tbTen.TabIndex = 3;
            this.tbTen.Leave += new System.EventHandler(this.tbTen_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chứng minh thư: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhân viên:";
            // 
            // grbTK
            // 
            this.grbTK.Controls.Add(this.tbCapcha);
            this.grbTK.Controls.Add(this.lbCapcha);
            this.grbTK.Controls.Add(this.label8);
            this.grbTK.Controls.Add(this.label7);
            this.grbTK.Controls.Add(this.tbCheckPass);
            this.grbTK.Controls.Add(this.tbPassword);
            this.grbTK.Controls.Add(this.tbUserName);
            this.grbTK.Controls.Add(this.label6);
            this.grbTK.Controls.Add(this.label5);
            this.grbTK.Controls.Add(this.label4);
            this.grbTK.Location = new System.Drawing.Point(12, 159);
            this.grbTK.Name = "grbTK";
            this.grbTK.Size = new System.Drawing.Size(473, 191);
            this.grbTK.TabIndex = 1;
            this.grbTK.TabStop = false;
            this.grbTK.Text = "Tạo Tài Khoản";
            // 
            // tbCapcha
            // 
            this.tbCapcha.Location = new System.Drawing.Point(138, 154);
            this.tbCapcha.Name = "tbCapcha";
            this.tbCapcha.Size = new System.Drawing.Size(239, 20);
            this.tbCapcha.TabIndex = 9;
            this.tbCapcha.Leave += new System.EventHandler(this.tbCapcha_Leave);
            // 
            // lbCapcha
            // 
            this.lbCapcha.AutoSize = true;
            this.lbCapcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCapcha.Location = new System.Drawing.Point(134, 116);
            this.lbCapcha.Name = "lbCapcha";
            this.lbCapcha.Size = new System.Drawing.Size(57, 20);
            this.lbCapcha.TabIndex = 8;
            this.lbCapcha.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nhập mã xác nhận:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã xác nhận:";
            // 
            // tbCheckPass
            // 
            this.tbCheckPass.Location = new System.Drawing.Point(138, 83);
            this.tbCheckPass.Name = "tbCheckPass";
            this.tbCheckPass.Size = new System.Drawing.Size(239, 20);
            this.tbCheckPass.TabIndex = 5;
            this.tbCheckPass.UseSystemPasswordChar = true;
            this.tbCheckPass.Leave += new System.EventHandler(this.tbCheckPass_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(138, 54);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(239, 20);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(138, 24);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(239, 20);
            this.tbUserName.TabIndex = 3;
            this.tbUserName.Leave += new System.EventHandler(this.tbUserName_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Xác nhận mật khẩu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên đăng nhập :";
            // 
            // btnDangki
            // 
            this.btnDangki.Location = new System.Drawing.Point(46, 376);
            this.btnDangki.Name = "btnDangki";
            this.btnDangki.Size = new System.Drawing.Size(75, 23);
            this.btnDangki.TabIndex = 2;
            this.btnDangki.Text = "Đăng kí";
            this.btnDangki.UseVisualStyleBackColor = true;
            this.btnDangki.Click += new System.EventHandler(this.btnDangki_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(372, 376);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 434);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDangki);
            this.Controls.Add(this.grbTK);
            this.Controls.Add(this.grb1);
            this.Name = "register";
            this.Text = "register";
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.grbTK.ResumeLayout(false);
            this.grbTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.TextBox tbCMT;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbTK;
        private System.Windows.Forms.TextBox tbCheckPass;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCapcha;
        private System.Windows.Forms.Label lbCapcha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDangki;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}