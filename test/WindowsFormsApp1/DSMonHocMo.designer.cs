﻿namespace DSMonHocMo
{
    partial class DSMonHocMo
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
            this.dgvDSMonHocMo = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NamHoc = new System.Windows.Forms.Label();
            this.cbHocKi = new System.Windows.Forms.ComboBox();
            this.HocKi = new System.Windows.Forms.Label();
            this.btXacNhanMonHocMo = new System.Windows.Forms.Button();
            this.btQuayLaiDSMHMo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonHocMo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDSMonHocMo);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 425);
            this.panel1.TabIndex = 0;
            // 
            // dgvDSMonHocMo
            // 
            this.dgvDSMonHocMo.AllowUserToOrderColumns = true;
            this.dgvDSMonHocMo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonHocMo.Location = new System.Drawing.Point(3, 53);
            this.dgvDSMonHocMo.Name = "dgvDSMonHocMo";
            this.dgvDSMonHocMo.RowHeadersWidth = 62;
            this.dgvDSMonHocMo.RowTemplate.Height = 28;
            this.dgvDSMonHocMo.Size = new System.Drawing.Size(911, 358);
            this.dgvDSMonHocMo.TabIndex = 0;
            this.dgvDSMonHocMo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMonHocMo_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.NamHoc);
            this.panel3.Controls.Add(this.cbHocKi);
            this.panel3.Controls.Add(this.HocKi);
            this.panel3.Location = new System.Drawing.Point(4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(914, 38);
            this.panel3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(559, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // NamHoc
            // 
            this.NamHoc.AutoSize = true;
            this.NamHoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamHoc.Location = new System.Drawing.Point(430, 6);
            this.NamHoc.Name = "NamHoc";
            this.NamHoc.Size = new System.Drawing.Size(123, 29);
            this.NamHoc.TabIndex = 2;
            this.NamHoc.Text = "Năm Học:";
            // 
            // cbHocKi
            // 
            this.cbHocKi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocKi.FormattingEnabled = true;
            this.cbHocKi.Location = new System.Drawing.Point(98, 5);
            this.cbHocKi.Name = "cbHocKi";
            this.cbHocKi.Size = new System.Drawing.Size(261, 30);
            this.cbHocKi.TabIndex = 1;
            this.cbHocKi.Text = "Chọn học kì";
            this.cbHocKi.SelectedIndexChanged += new System.EventHandler(this.CbHocKi_SelectedIndexChanged);
            // 
            // HocKi
            // 
            this.HocKi.AutoSize = true;
            this.HocKi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HocKi.Location = new System.Drawing.Point(3, 6);
            this.HocKi.Name = "HocKi";
            this.HocKi.Size = new System.Drawing.Size(92, 29);
            this.HocKi.TabIndex = 0;
            this.HocKi.Text = "Học kì:";
            // 
            // btXacNhanMonHocMo
            // 
            this.btXacNhanMonHocMo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXacNhanMonHocMo.Location = new System.Drawing.Point(506, 436);
            this.btXacNhanMonHocMo.Name = "btXacNhanMonHocMo";
            this.btXacNhanMonHocMo.Size = new System.Drawing.Size(189, 42);
            this.btXacNhanMonHocMo.TabIndex = 3;
            this.btXacNhanMonHocMo.Text = "Xác Nhận";
            this.btXacNhanMonHocMo.UseVisualStyleBackColor = true;
            // 
            // btQuayLaiDSMHMo
            // 
            this.btQuayLaiDSMHMo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuayLaiDSMHMo.Location = new System.Drawing.Point(187, 436);
            this.btQuayLaiDSMHMo.Name = "btQuayLaiDSMHMo";
            this.btQuayLaiDSMHMo.Size = new System.Drawing.Size(176, 42);
            this.btQuayLaiDSMHMo.TabIndex = 4;
            this.btQuayLaiDSMHMo.Text = "Quay lại";
            this.btQuayLaiDSMHMo.UseVisualStyleBackColor = true;
            // 
            // DSMonHocMo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 490);
            this.Controls.Add(this.btQuayLaiDSMHMo);
            this.Controls.Add(this.btXacNhanMonHocMo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "DSMonHocMo";
            this.Text = "Danh sách môn học mở";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonHocMo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NamHoc;
        private System.Windows.Forms.ComboBox cbHocKi;
        private System.Windows.Forms.Label HocKi;
        private System.Windows.Forms.Button btXacNhanMonHocMo;
        private System.Windows.Forms.Button btQuayLaiDSMHMo;
        private System.Windows.Forms.DataGridView dgvDSMonHocMo;
    }
}

