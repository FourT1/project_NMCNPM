namespace DKHP
{
    partial class fDKHP
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
            this.lbDKHP = new System.Windows.Forms.Label();
            this.fInfoDKHP = new System.Windows.Forms.GroupBox();
            this.bttAccessDKHP = new System.Windows.Forms.Button();
            this.bttDKHP = new System.Windows.Forms.Button();
            this.tbHocKy = new System.Windows.Forms.TextBox();
            this.tbNamHoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSoPhieu = new System.Windows.Forms.TextBox();
            this.tbMSSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDSMDK = new System.Windows.Forms.GroupBox();
            this.dgvDSMDK = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttXoaMonHoc = new System.Windows.Forms.Button();
            this.gbDSMHM = new System.Windows.Forms.GroupBox();
            this.dgvDSMHM = new System.Windows.Forms.DataGridView();
            this.gbAccessDKHP = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSoPhieuAccess = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMSSVAccess = new System.Windows.Forms.TextBox();
            this.fInfoDKHP.SuspendLayout();
            this.gbDSMDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMDK)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbDSMHM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHM)).BeginInit();
            this.gbAccessDKHP.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDKHP
            // 
            this.lbDKHP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDKHP.AutoSize = true;
            this.lbDKHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDKHP.Location = new System.Drawing.Point(288, 9);
            this.lbDKHP.Name = "lbDKHP";
            this.lbDKHP.Size = new System.Drawing.Size(323, 33);
            this.lbDKHP.TabIndex = 0;
            this.lbDKHP.Text = "ĐĂNG KÝ HỌC PHẦN";
            this.lbDKHP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbDKHP.Click += new System.EventHandler(this.label1_Click);
            // 
            // fInfoDKHP
            // 
            this.fInfoDKHP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fInfoDKHP.Controls.Add(this.bttDKHP);
            this.fInfoDKHP.Controls.Add(this.tbHocKy);
            this.fInfoDKHP.Controls.Add(this.tbNamHoc);
            this.fInfoDKHP.Controls.Add(this.label6);
            this.fInfoDKHP.Controls.Add(this.label5);
            this.fInfoDKHP.Controls.Add(this.dtpNgayLap);
            this.fInfoDKHP.Controls.Add(this.label4);
            this.fInfoDKHP.Controls.Add(this.tbSoPhieu);
            this.fInfoDKHP.Controls.Add(this.tbMSSV);
            this.fInfoDKHP.Controls.Add(this.label3);
            this.fInfoDKHP.Controls.Add(this.label2);
            this.fInfoDKHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fInfoDKHP.Location = new System.Drawing.Point(12, 39);
            this.fInfoDKHP.Name = "fInfoDKHP";
            this.fInfoDKHP.Size = new System.Drawing.Size(462, 138);
            this.fInfoDKHP.TabIndex = 3;
            this.fInfoDKHP.TabStop = false;
            this.fInfoDKHP.Text = "Thông tin phiếu ĐKHP";
            this.fInfoDKHP.Enter += new System.EventHandler(this.fInfoDKHP_Enter);
            // 
            // bttAccessDKHP
            // 
            this.bttAccessDKHP.Location = new System.Drawing.Point(333, 51);
            this.bttAccessDKHP.Name = "bttAccessDKHP";
            this.bttAccessDKHP.Size = new System.Drawing.Size(96, 21);
            this.bttAccessDKHP.TabIndex = 12;
            this.bttAccessDKHP.Text = "Truy cập";
            this.bttAccessDKHP.UseVisualStyleBackColor = true;
            this.bttAccessDKHP.Click += new System.EventHandler(this.bttAccessDKHP_Click);
            // 
            // bttDKHP
            // 
            this.bttDKHP.Location = new System.Drawing.Point(334, 105);
            this.bttDKHP.Name = "bttDKHP";
            this.bttDKHP.Size = new System.Drawing.Size(94, 20);
            this.bttDKHP.TabIndex = 5;
            this.bttDKHP.Text = "Đăng ký ";
            this.bttDKHP.UseVisualStyleBackColor = true;
            this.bttDKHP.Click += new System.EventHandler(this.bttDKHP_Click);
            // 
            // tbHocKy
            // 
            this.tbHocKy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbHocKy.Location = new System.Drawing.Point(101, 83);
            this.tbHocKy.Name = "tbHocKy";
            this.tbHocKy.ReadOnly = true;
            this.tbHocKy.Size = new System.Drawing.Size(67, 20);
            this.tbHocKy.TabIndex = 11;
            this.tbHocKy.TextChanged += new System.EventHandler(this.tbHocKy_TextChanged);
            // 
            // tbNamHoc
            // 
            this.tbNamHoc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbNamHoc.Location = new System.Drawing.Point(333, 51);
            this.tbNamHoc.Name = "tbNamHoc";
            this.tbNamHoc.ReadOnly = true;
            this.tbNamHoc.Size = new System.Drawing.Size(95, 20);
            this.tbNamHoc.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(254, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Năm học:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Học kỳ:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpNgayLap.Location = new System.Drawing.Point(101, 45);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(121, 24);
            this.dtpNgayLap.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày lập:";
            // 
            // tbSoPhieu
            // 
            this.tbSoPhieu.Location = new System.Drawing.Point(101, 17);
            this.tbSoPhieu.Name = "tbSoPhieu";
            this.tbSoPhieu.Size = new System.Drawing.Size(121, 20);
            this.tbSoPhieu.TabIndex = 4;
            // 
            // tbMSSV
            // 
            this.tbMSSV.Location = new System.Drawing.Point(334, 17);
            this.tbMSSV.Name = "tbMSSV";
            this.tbMSSV.Size = new System.Drawing.Size(95, 20);
            this.tbMSSV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "MSSV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số phiếu: ";
            // 
            // gbDSMDK
            // 
            this.gbDSMDK.Controls.Add(this.dgvDSMDK);
            this.gbDSMDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDSMDK.Location = new System.Drawing.Point(12, 270);
            this.gbDSMDK.Name = "gbDSMDK";
            this.gbDSMDK.Size = new System.Drawing.Size(462, 251);
            this.gbDSMDK.TabIndex = 4;
            this.gbDSMDK.TabStop = false;
            this.gbDSMDK.Text = "Danh sách môn học đã đăng ký";
            // 
            // dgvDSMDK
            // 
            this.dgvDSMDK.AllowUserToAddRows = false;
            this.dgvDSMDK.AllowUserToDeleteRows = false;
            this.dgvDSMDK.AllowUserToOrderColumns = true;
            this.dgvDSMDK.AllowUserToResizeColumns = false;
            this.dgvDSMDK.AllowUserToResizeRows = false;
            this.dgvDSMDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMDK.Location = new System.Drawing.Point(6, 19);
            this.dgvDSMDK.Name = "dgvDSMDK";
            this.dgvDSMDK.ReadOnly = true;
            this.dgvDSMDK.RowHeadersVisible = false;
            this.dgvDSMDK.RowHeadersWidth = 62;
            this.dgvDSMDK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSMDK.Size = new System.Drawing.Size(450, 293);
            this.dgvDSMDK.TabIndex = 0;
            this.dgvDSMDK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bttXoaMonHoc);
            this.panel1.Location = new System.Drawing.Point(12, 527);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 47);
            this.panel1.TabIndex = 5;
            // 
            // bttXoaMonHoc
            // 
            this.bttXoaMonHoc.Location = new System.Drawing.Point(6, 0);
            this.bttXoaMonHoc.Name = "bttXoaMonHoc";
            this.bttXoaMonHoc.Size = new System.Drawing.Size(78, 41);
            this.bttXoaMonHoc.TabIndex = 1;
            this.bttXoaMonHoc.Text = "Xoá môn học";
            this.bttXoaMonHoc.UseVisualStyleBackColor = true;
            this.bttXoaMonHoc.Click += new System.EventHandler(this.bttXoaMonHoc_Click);
            // 
            // gbDSMHM
            // 
            this.gbDSMHM.Controls.Add(this.dgvDSMHM);
            this.gbDSMHM.Location = new System.Drawing.Point(480, 39);
            this.gbDSMHM.Name = "gbDSMHM";
            this.gbDSMHM.Size = new System.Drawing.Size(373, 535);
            this.gbDSMHM.TabIndex = 6;
            this.gbDSMHM.TabStop = false;
            this.gbDSMHM.Text = "Danh sách môn học mở";
            // 
            // dgvDSMHM
            // 
            this.dgvDSMHM.AllowUserToAddRows = false;
            this.dgvDSMHM.AllowUserToDeleteRows = false;
            this.dgvDSMHM.AllowUserToResizeColumns = false;
            this.dgvDSMHM.AllowUserToResizeRows = false;
            this.dgvDSMHM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMHM.Location = new System.Drawing.Point(6, 13);
            this.dgvDSMHM.Name = "dgvDSMHM";
            this.dgvDSMHM.ReadOnly = true;
            this.dgvDSMHM.RowHeadersVisible = false;
            this.dgvDSMHM.RowHeadersWidth = 62;
            this.dgvDSMHM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSMHM.Size = new System.Drawing.Size(361, 516);
            this.dgvDSMHM.TabIndex = 0;
            this.dgvDSMHM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvDSMHM.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMHM_CellDoubleClick);
            this.dgvDSMHM.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDSMHM_CellMouseClick);
            // 
            // gbAccessDKHP
            // 
            this.gbAccessDKHP.Controls.Add(this.tbMSSVAccess);
            this.gbAccessDKHP.Controls.Add(this.label7);
            this.gbAccessDKHP.Controls.Add(this.bttAccessDKHP);
            this.gbAccessDKHP.Controls.Add(this.tbSoPhieuAccess);
            this.gbAccessDKHP.Controls.Add(this.label1);
            this.gbAccessDKHP.Location = new System.Drawing.Point(12, 183);
            this.gbAccessDKHP.Name = "gbAccessDKHP";
            this.gbAccessDKHP.Size = new System.Drawing.Size(462, 81);
            this.gbAccessDKHP.TabIndex = 7;
            this.gbAccessDKHP.TabStop = false;
            this.gbAccessDKHP.Text = "Truy cập phiếu DKHP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Số phiếu: ";
            // 
            // tbSoPhieuAccess
            // 
            this.tbSoPhieuAccess.Location = new System.Drawing.Point(101, 17);
            this.tbSoPhieuAccess.Name = "tbSoPhieuAccess";
            this.tbSoPhieuAccess.Size = new System.Drawing.Size(121, 20);
            this.tbSoPhieuAccess.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(254, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "MSSV:";
            // 
            // tbMSSVAccess
            // 
            this.tbMSSVAccess.Location = new System.Drawing.Point(334, 16);
            this.tbMSSVAccess.Name = "tbMSSVAccess";
            this.tbMSSVAccess.Size = new System.Drawing.Size(95, 20);
            this.tbMSSVAccess.TabIndex = 12;
            // 
            // fDKHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 580);
            this.Controls.Add(this.gbAccessDKHP);
            this.Controls.Add(this.gbDSMHM);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbDSMDK);
            this.Controls.Add(this.fInfoDKHP);
            this.Controls.Add(this.lbDKHP);
            this.Name = "fDKHP";
            this.Text = "Đăng ký học phần";
            this.fInfoDKHP.ResumeLayout(false);
            this.fInfoDKHP.PerformLayout();
            this.gbDSMDK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMDK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbDSMHM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHM)).EndInit();
            this.gbAccessDKHP.ResumeLayout(false);
            this.gbAccessDKHP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDKHP;
        private System.Windows.Forms.GroupBox fInfoDKHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSoPhieu;
        private System.Windows.Forms.TextBox tbMSSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbDSMDK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbDSMHM;
        private System.Windows.Forms.TextBox tbNamHoc;
        private System.Windows.Forms.DataGridView dgvDSMHM;
        private System.Windows.Forms.DataGridView dgvDSMDK;
        private System.Windows.Forms.Button bttXoaMonHoc;
        private System.Windows.Forms.TextBox tbHocKy;
        private System.Windows.Forms.Button bttAccessDKHP;
        private System.Windows.Forms.Button bttDKHP;
        private System.Windows.Forms.GroupBox gbAccessDKHP;
        private System.Windows.Forms.TextBox tbSoPhieuAccess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMSSVAccess;
        private System.Windows.Forms.Label label7;
    }
}

