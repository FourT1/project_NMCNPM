namespace WindowsFormsApp1
{
    partial class QuanLySV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cbbDoiTuong = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbbNganh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbbDiaPhuong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbMSSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1654, 106);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý sinh viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1654, 366);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1347, 282);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 55);
            this.button3.TabIndex = 12;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(718, 282);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 55);
            this.button2.TabIndex = 11;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(107, 282);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(209, 55);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cbbDoiTuong);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Location = new System.Drawing.Point(1138, 132);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(511, 55);
            this.panel10.TabIndex = 9;
            // 
            // cbbDoiTuong
            // 
            this.cbbDoiTuong.FormattingEnabled = true;
            this.cbbDoiTuong.Location = new System.Drawing.Point(138, 11);
            this.cbbDoiTuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbDoiTuong.Name = "cbbDoiTuong";
            this.cbbDoiTuong.Size = new System.Drawing.Size(368, 28);
            this.cbbDoiTuong.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Đối tượng:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbbKhoa);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Location = new System.Drawing.Point(1138, 70);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(511, 55);
            this.panel9.TabIndex = 8;
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(138, 11);
            this.cbbKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(368, 28);
            this.cbbKhoa.TabIndex = 1;
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Khoa:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbbNganh);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(579, 195);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(520, 55);
            this.panel8.TabIndex = 7;
            // 
            // cbbNganh
            // 
            this.cbbNganh.FormattingEnabled = true;
            this.cbbNganh.Location = new System.Drawing.Point(138, 11);
            this.cbbNganh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbNganh.Name = "cbbNganh";
            this.cbbNganh.Size = new System.Drawing.Size(368, 28);
            this.cbbNganh.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngành:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbbDiaPhuong);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(579, 132);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(520, 55);
            this.panel7.TabIndex = 6;
            // 
            // cbbDiaPhuong
            // 
            this.cbbDiaPhuong.FormattingEnabled = true;
            this.cbbDiaPhuong.Location = new System.Drawing.Point(138, 11);
            this.cbbDiaPhuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbDiaPhuong.Name = "cbbDiaPhuong";
            this.cbbDiaPhuong.Size = new System.Drawing.Size(368, 28);
            this.cbbDiaPhuong.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa phương:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rdbNu);
            this.panel6.Controls.Add(this.rdbNam);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(579, 70);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(520, 55);
            this.panel6.TabIndex = 3;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(333, 10);
            this.rdbNu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(54, 24);
            this.rdbNu.TabIndex = 4;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(138, 10);
            this.rdbNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(67, 24);
            this.rdbNam.TabIndex = 3;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtpNgaySinh);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(32, 195);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(511, 55);
            this.panel5.TabIndex = 2;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(125, 15);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(381, 26);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbTen);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(32, 132);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(511, 55);
            this.panel4.TabIndex = 1;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(125, 11);
            this.tbTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(381, 26);
            this.tbTen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbMSSV);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(32, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 55);
            this.panel3.TabIndex = 0;
            // 
            // tbMSSV
            // 
            this.tbMSSV.Location = new System.Drawing.Point(125, 12);
            this.tbMSSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMSSV.Name = "tbMSSV";
            this.tbMSSV.Size = new System.Drawing.Size(381, 26);
            this.tbMSSV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "MSSV:";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(0, 472);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1654, 437);
            this.label11.TabIndex = 5;
            this.label11.Text = "Danh sách sinh viên";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvSV
            // 
            this.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSV.Location = new System.Drawing.Point(14, 554);
            this.dgvSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.RowHeadersWidth = 51;
            this.dgvSV.RowTemplate.Height = 24;
            this.dgvSV.Size = new System.Drawing.Size(1627, 355);
            this.dgvSV.TabIndex = 6;
            this.dgvSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // QuanLySV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 909);
            this.Controls.Add(this.dgvSV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanLySV";
            this.Text = "YC1";
            this.Load += new System.EventHandler(this.QuanLySV_Load);
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cbbDoiTuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cbbNganh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbbDiaPhuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbMSSV;
        private System.Windows.Forms.DataGridView dgvSV;
    }
}