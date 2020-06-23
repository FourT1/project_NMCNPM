namespace QuanLyThuHocPhi
{
    partial class NhanVienInfor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbCMT = new System.Windows.Forms.Label();
            this.lbSoHD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chứng minh thư:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng số hóa đơn đã lập:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(173, 56);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "label5";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(173, 92);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(35, 13);
            this.lbSDT.TabIndex = 6;
            this.lbSDT.Text = "label6";
            // 
            // lbCMT
            // 
            this.lbCMT.AutoSize = true;
            this.lbCMT.Location = new System.Drawing.Point(173, 133);
            this.lbCMT.Name = "lbCMT";
            this.lbCMT.Size = new System.Drawing.Size(35, 13);
            this.lbCMT.TabIndex = 7;
            this.lbCMT.Text = "label7";
            // 
            // lbSoHD
            // 
            this.lbSoHD.AutoSize = true;
            this.lbSoHD.Location = new System.Drawing.Point(173, 174);
            this.lbSoHD.Name = "lbSoHD";
            this.lbSoHD.Size = new System.Drawing.Size(35, 13);
            this.lbSoHD.TabIndex = 8;
            this.lbSoHD.Text = "label8";
            // 
            // NhanVienInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 310);
            this.Controls.Add(this.lbSoHD);
            this.Controls.Add(this.lbCMT);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NhanVienInfor";
            this.Text = "NhanVienInfor";
            this.Load += new System.EventHandler(this.NhanVienInfor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbCMT;
        private System.Windows.Forms.Label lbSoHD;
    }
}