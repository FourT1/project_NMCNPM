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
            this.Nganh = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelKhoa = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.labelKhoa);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.Nganh);
            this.panel2.Location = new System.Drawing.Point(3, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 50);
            this.panel2.TabIndex = 0;
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
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(359, 30);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Chọn ngành học";
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
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(722, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(421, 30);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "Chọn khoa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(3, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1157, 310);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Học Kì";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Môn học";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 350;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ghi chú";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 600;
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelKhoa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Nganh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

