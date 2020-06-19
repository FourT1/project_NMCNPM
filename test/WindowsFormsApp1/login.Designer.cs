namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dsmonhoc = new System.Windows.Forms.Button();
            this.dsmonhocmo = new System.Windows.Forms.Button();
            this.dssvchuadonghp = new System.Windows.Forms.Button();
            this.cthoc = new System.Windows.Forms.Button();
            this.dkhocphan = new System.Windows.Forms.Button();
            this.phieuthuhocphi = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(421, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 42);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(595, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 30);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(428, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 44);
            this.panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(167, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 30);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(421, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(429, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.login_Click);
            // 
            // dsmonhoc
            // 
            this.dsmonhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsmonhoc.Location = new System.Drawing.Point(38, 35);
            this.dsmonhoc.Name = "dsmonhoc";
            this.dsmonhoc.Size = new System.Drawing.Size(300, 44);
            this.dsmonhoc.TabIndex = 3;
            this.dsmonhoc.Text = "Danh Sách Môn Học";
            this.dsmonhoc.UseVisualStyleBackColor = true;
            // 
            // dsmonhocmo
            // 
            this.dsmonhocmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsmonhocmo.Location = new System.Drawing.Point(38, 122);
            this.dsmonhocmo.Name = "dsmonhocmo";
            this.dsmonhocmo.Size = new System.Drawing.Size(300, 55);
            this.dsmonhocmo.TabIndex = 4;
            this.dsmonhocmo.Text = "Danh Sách Môn Học Mở";
            this.dsmonhocmo.UseVisualStyleBackColor = true;
            // 
            // dssvchuadonghp
            // 
            this.dssvchuadonghp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dssvchuadonghp.Location = new System.Drawing.Point(38, 212);
            this.dssvchuadonghp.Name = "dssvchuadonghp";
            this.dssvchuadonghp.Size = new System.Drawing.Size(300, 75);
            this.dssvchuadonghp.TabIndex = 5;
            this.dssvchuadonghp.Text = "Danh Sách SV Chưa Đóng Học Phí";
            this.dssvchuadonghp.UseVisualStyleBackColor = true;
            // 
            // cthoc
            // 
            this.cthoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cthoc.Location = new System.Drawing.Point(38, 323);
            this.cthoc.Name = "cthoc";
            this.cthoc.Size = new System.Drawing.Size(300, 55);
            this.cthoc.TabIndex = 6;
            this.cthoc.Text = "Chương Trình Học";
            this.cthoc.UseVisualStyleBackColor = true;
            // 
            // dkhocphan
            // 
            this.dkhocphan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dkhocphan.Location = new System.Drawing.Point(38, 427);
            this.dkhocphan.Name = "dkhocphan";
            this.dkhocphan.Size = new System.Drawing.Size(300, 51);
            this.dkhocphan.TabIndex = 7;
            this.dkhocphan.Text = "Đăng Ký Học Phần";
            this.dkhocphan.UseVisualStyleBackColor = true;
            this.dkhocphan.Click += new System.EventHandler(this.button6_Click);
            // 
            // phieuthuhocphi
            // 
            this.phieuthuhocphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phieuthuhocphi.Location = new System.Drawing.Point(38, 526);
            this.phieuthuhocphi.Name = "phieuthuhocphi";
            this.phieuthuhocphi.Size = new System.Drawing.Size(300, 51);
            this.phieuthuhocphi.TabIndex = 8;
            this.phieuthuhocphi.Text = "Phiếu Thu Học Phí";
            this.phieuthuhocphi.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 602);
            this.Controls.Add(this.phieuthuhocphi);
            this.Controls.Add(this.dkhocphan);
            this.Controls.Add(this.cthoc);
            this.Controls.Add(this.dssvchuadonghp);
            this.Controls.Add(this.dsmonhocmo);
            this.Controls.Add(this.dsmonhoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button dsmonhoc;
        private System.Windows.Forms.Button dsmonhocmo;
        private System.Windows.Forms.Button dssvchuadonghp;
        private System.Windows.Forms.Button cthoc;
        private System.Windows.Forms.Button dkhocphan;
        private System.Windows.Forms.Button phieuthuhocphi;
    }
}

