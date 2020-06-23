namespace QuanLyThuHocPhi
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbFogot = new System.Windows.Forms.Label();
            this.lbChange = new System.Windows.Forms.Label();
            this.lbTaoTK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(86, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(171, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đăng Nhập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(179, 81);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(209, 20);
            this.tbLogin.TabIndex = 3;
            this.tbLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLogin_KeyPress);
            this.tbLogin.Validating += new System.ComponentModel.CancelEventHandler(this.tbLogin_Validating);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(179, 122);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(209, 20);
            this.tbPass.TabIndex = 4;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPass_KeyPress);
            this.tbPass.Validating += new System.ComponentModel.CancelEventHandler(this.tbPass_Validating);
            // 
            // btnLogin
            // 
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(178, 179);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(313, 179);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // lbFogot
            // 
            this.lbFogot.AutoSize = true;
            this.lbFogot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbFogot.ForeColor = System.Drawing.Color.Red;
            this.lbFogot.Location = new System.Drawing.Point(179, 149);
            this.lbFogot.Name = "lbFogot";
            this.lbFogot.Size = new System.Drawing.Size(95, 13);
            this.lbFogot.TabIndex = 7;
            this.lbFogot.Text = "Quên Mật Khẩu";
            this.lbFogot.Click += new System.EventHandler(this.lbFogot_Click);
            // 
            // lbChange
            // 
            this.lbChange.AutoSize = true;
            this.lbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbChange.ForeColor = System.Drawing.Color.Red;
            this.lbChange.Location = new System.Drawing.Point(304, 149);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(84, 13);
            this.lbChange.TabIndex = 8;
            this.lbChange.Text = "Đổi Mật Khẩu";
            this.lbChange.Click += new System.EventHandler(this.lbChange_Click);
            // 
            // lbTaoTK
            // 
            this.lbTaoTK.AutoSize = true;
            this.lbTaoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTaoTK.ForeColor = System.Drawing.Color.Red;
            this.lbTaoTK.Location = new System.Drawing.Point(13, 240);
            this.lbTaoTK.Name = "lbTaoTK";
            this.lbTaoTK.Size = new System.Drawing.Size(222, 15);
            this.lbTaoTK.TabIndex = 9;
            this.lbTaoTK.Text = "Bạn chưa có tài khoản... Đăng kí?";
            this.lbTaoTK.Click += new System.EventHandler(this.lbTaoTK_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(553, 265);
            this.Controls.Add(this.lbTaoTK);
            this.Controls.Add(this.lbChange);
            this.Controls.Add(this.lbFogot);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label lbFogot;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.Label lbTaoTK;
    }
}

