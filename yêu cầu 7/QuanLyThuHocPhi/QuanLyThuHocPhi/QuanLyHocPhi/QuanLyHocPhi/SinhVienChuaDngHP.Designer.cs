namespace QuanLyHocPhi
{
    partial class SinhVienChuaDngHP
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
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvChuaDongHP = new System.Windows.Forms.DataGridView();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btInPhieu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuaDongHP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbHocKy);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 61);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Items.AddRange(new object[] {
            "Học kỳ I",
            "Học kỳ II"});
            this.cbHocKy.Location = new System.Drawing.Point(144, 21);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(109, 24);
            this.cbHocKy.TabIndex = 1;
            this.cbHocKy.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Học kỳ:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvChuaDongHP);
            this.panel2.Location = new System.Drawing.Point(12, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1307, 311);
            this.panel2.TabIndex = 1;
            // 
            // dtgvChuaDongHP
            // 
            this.dtgvChuaDongHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChuaDongHP.Location = new System.Drawing.Point(3, 3);
            this.dtgvChuaDongHP.Name = "dtgvChuaDongHP";
            this.dtgvChuaDongHP.RowHeadersWidth = 51;
            this.dtgvChuaDongHP.RowTemplate.Height = 24;
            this.dtgvChuaDongHP.Size = new System.Drawing.Size(1270, 328);
            this.dtgvChuaDongHP.TabIndex = 0;
            this.dtgvChuaDongHP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChuaDongHP_CellContentClick);
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Items.AddRange(new object[] {
            "Học kỳ I",
            "Học kỳ II"});
            this.cbNamHoc.Location = new System.Drawing.Point(707, 35);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(109, 24);
            this.cbNamHoc.TabIndex = 2;
            this.cbNamHoc.SelectedIndexChanged += new System.EventHandler(this.cbNamHoc_SelectedIndexChanged);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(328, 416);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(201, 86);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btInPhieu
            // 
            this.btInPhieu.Location = new System.Drawing.Point(628, 427);
            this.btInPhieu.Name = "btInPhieu";
            this.btInPhieu.Size = new System.Drawing.Size(201, 65);
            this.btInPhieu.TabIndex = 4;
            this.btInPhieu.Text = "In phiếu";
            this.btInPhieu.UseVisualStyleBackColor = true;
            this.btInPhieu.Click += new System.EventHandler(this.btInPhieu_Click);
            // 
            // SinhVienChuaDngHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 680);
            this.Controls.Add(this.btInPhieu);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.cbNamHoc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SinhVienChuaDngHP";
            this.Text = "DANH SÁCH SINH VIÊN CHƯA HOÀN THÀNH VIỆC ĐÓNG HỌC PHÍ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuaDongHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvChuaDongHP;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btInPhieu;
    }
}

