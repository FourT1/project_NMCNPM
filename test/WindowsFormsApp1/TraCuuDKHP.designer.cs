﻿namespace TraCuu_DKHP
{
    partial class fTraCuuDKHP
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDKHP = new System.Windows.Forms.DataGridView();
            this.gbAccessDKHP = new System.Windows.Forms.GroupBox();
            this.tbMSSVAccess = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSoPhieuAccess = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bttDKMH = new System.Windows.Forms.Button();
            this.bttXoaMH = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvInfoDKHP = new System.Windows.Forms.DataGridView();
            this.gbInfoDKHP = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSoPhieu = new System.Windows.Forms.TextBox();
            this.tbMSSV = new System.Windows.Forms.TextBox();
            this.tbHocKy = new System.Windows.Forms.TextBox();
            this.tbNamHoc = new System.Windows.Forms.TextBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttReset = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDKHP)).BeginInit();
            this.gbAccessDKHP.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoDKHP)).BeginInit();
            this.gbInfoDKHP.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
<<<<<<< HEAD
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 0);
>>>>>>> c8a98dfb559dbc34296e565520c01f27918362c7
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tra cứu phiếu ĐKHP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
<<<<<<< HEAD
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.dtpNgayLap);
            this.gbInfo.Controls.Add(this.tbNamHoc);
            this.gbInfo.Controls.Add(this.tbHocKy);
            this.gbInfo.Controls.Add(this.tbMSSV);
            this.gbInfo.Controls.Add(this.tbSoPhieu);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Location = new System.Drawing.Point(16, 50);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInfo.Size = new System.Drawing.Size(523, 206);
            this.gbInfo.TabIndex = 1;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin phiếu ĐKHP";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(117, 85);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(131, 22);
            this.dtpNgayLap.TabIndex = 10;
            // 
            // tbNamHoc
            // 
            this.tbNamHoc.Location = new System.Drawing.Point(364, 138);
            this.tbNamHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNamHoc.Name = "tbNamHoc";
            this.tbNamHoc.Size = new System.Drawing.Size(132, 22);
            this.tbNamHoc.TabIndex = 9;
            // 
            // tbHocKy
            // 
            this.tbHocKy.Location = new System.Drawing.Point(117, 138);
            this.tbHocKy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbHocKy.Name = "tbHocKy";
            this.tbHocKy.Size = new System.Drawing.Size(132, 22);
            this.tbHocKy.TabIndex = 8;
            // 
            // tbMSSV
            // 
            this.tbMSSV.Location = new System.Drawing.Point(364, 37);
            this.tbMSSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMSSV.Name = "tbMSSV";
            this.tbMSSV.Size = new System.Drawing.Size(132, 22);
            this.tbMSSV.TabIndex = 7;
            // 
            // tbSoPhieu
            // 
            this.tbSoPhieu.Location = new System.Drawing.Point(117, 37);
            this.tbSoPhieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSoPhieu.Name = "tbSoPhieu";
            this.tbSoPhieu.Size = new System.Drawing.Size(132, 22);
            this.tbSoPhieu.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày lập: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Năm học: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Học kỳ: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "MSSV: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phiếu: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(567, 143);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(472, 506);
=======
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDKHP);
            this.groupBox2.Location = new System.Drawing.Point(425, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 430);
>>>>>>> c8a98dfb559dbc34296e565520c01f27918362c7
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu ĐKHP";
            // 
<<<<<<< HEAD
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(455, 566);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbInfoDKHP
            // 
            this.gbInfoDKHP.Controls.Add(this.dataGridView2);
            this.gbInfoDKHP.Location = new System.Drawing.Point(16, 263);
            this.gbInfoDKHP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInfoDKHP.Name = "gbInfoDKHP";
            this.gbInfoDKHP.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInfoDKHP.Size = new System.Drawing.Size(523, 319);
            this.gbInfoDKHP.TabIndex = 11;
            this.gbInfoDKHP.TabStop = false;
            this.gbInfoDKHP.Text = "Thông tin phiếu ĐKHP";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 23);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(507, 288);
            this.dataGridView2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(16, 583);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 65);
            this.panel1.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, -1);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "Xoá";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Làm mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tra cứu";
            this.button1.UseVisualStyleBackColor = true;
=======
            // dgvDKHP
            // 
            this.dgvDKHP.AllowUserToAddRows = false;
            this.dgvDKHP.AllowUserToDeleteRows = false;
            this.dgvDKHP.AllowUserToOrderColumns = true;
            this.dgvDKHP.AllowUserToResizeColumns = false;
            this.dgvDKHP.AllowUserToResizeRows = false;
            this.dgvDKHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDKHP.Location = new System.Drawing.Point(7, 20);
            this.dgvDKHP.MultiSelect = false;
            this.dgvDKHP.Name = "dgvDKHP";
            this.dgvDKHP.ReadOnly = true;
            this.dgvDKHP.RowHeadersVisible = false;
            this.dgvDKHP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDKHP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDKHP.Size = new System.Drawing.Size(526, 404);
            this.dgvDKHP.TabIndex = 0;
            this.dgvDKHP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDKHP_CellClick);
            this.dgvDKHP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
>>>>>>> c8a98dfb559dbc34296e565520c01f27918362c7
            // 
            // gbAccessDKHP
            // 
            this.gbAccessDKHP.Controls.Add(this.tbMSSVAccess);
            this.gbAccessDKHP.Controls.Add(this.label6);
            this.gbAccessDKHP.Controls.Add(this.tbSoPhieuAccess);
            this.gbAccessDKHP.Controls.Add(this.label8);
            this.gbAccessDKHP.Location = new System.Drawing.Point(567, 50);
            this.gbAccessDKHP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAccessDKHP.Name = "gbAccessDKHP";
<<<<<<< HEAD
            this.gbAccessDKHP.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAccessDKHP.Size = new System.Drawing.Size(472, 85);
=======
            this.gbAccessDKHP.Size = new System.Drawing.Size(332, 50);
>>>>>>> c8a98dfb559dbc34296e565520c01f27918362c7
            this.gbAccessDKHP.TabIndex = 13;
            this.gbAccessDKHP.TabStop = false;
            this.gbAccessDKHP.Text = "Truy cập phiếu DKHP";
            // 
            // tbMSSVAccess
            // 
            this.tbMSSVAccess.Location = new System.Drawing.Point(321, 18);
            this.tbMSSVAccess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMSSVAccess.Name = "tbMSSVAccess";
            this.tbMSSVAccess.Size = new System.Drawing.Size(100, 22);
            this.tbMSSVAccess.TabIndex = 12;
            this.tbMSSVAccess.TextChanged += new System.EventHandler(this.tbMSSVAccess_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(255, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "MSSV:";
            // 
<<<<<<< HEAD
            // bttAccessDKHP
            // 
            this.bttAccessDKHP.Location = new System.Drawing.Point(321, 52);
            this.bttAccessDKHP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttAccessDKHP.Name = "bttAccessDKHP";
            this.bttAccessDKHP.Size = new System.Drawing.Size(101, 26);
            this.bttAccessDKHP.TabIndex = 12;
            this.bttAccessDKHP.Text = "Truy cập";
            this.bttAccessDKHP.UseVisualStyleBackColor = true;
            // 
=======
>>>>>>> c8a98dfb559dbc34296e565520c01f27918362c7
            // tbSoPhieuAccess
            // 
            this.tbSoPhieuAccess.Location = new System.Drawing.Point(119, 18);
            this.tbSoPhieuAccess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSoPhieuAccess.Name = "tbSoPhieuAccess";
            this.tbSoPhieuAccess.Size = new System.Drawing.Size(99, 22);
            this.tbSoPhieuAccess.TabIndex = 14;
            this.tbSoPhieuAccess.TextChanged += new System.EventHandler(this.tbSoPhieuAccess_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Số phiếu: ";
            // 
            // bttDKMH
            // 
            this.bttDKMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDKMH.Location = new System.Drawing.Point(6, -1);
            this.bttDKMH.Name = "bttDKMH";
            this.bttDKMH.Size = new System.Drawing.Size(108, 54);
            this.bttDKMH.TabIndex = 0;
            this.bttDKMH.Text = "Đăng ký môn học";
            this.bttDKMH.UseVisualStyleBackColor = true;
            this.bttDKMH.Click += new System.EventHandler(this.bttDKMH_Click);
            // 
            // bttXoaMH
            // 
            this.bttXoaMH.Location = new System.Drawing.Point(141, -1);
            this.bttXoaMH.Name = "bttXoaMH";
            this.bttXoaMH.Size = new System.Drawing.Size(116, 54);
            this.bttXoaMH.TabIndex = 2;
            this.bttXoaMH.Text = "Xoá";
            this.bttXoaMH.UseVisualStyleBackColor = true;
            this.bttXoaMH.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bttXoaMH);
            this.panel1.Controls.Add(this.bttDKMH);
            this.panel1.Location = new System.Drawing.Point(12, 474);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 53);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvInfoDKHP
            // 
            this.dgvInfoDKHP.AllowUserToAddRows = false;
            this.dgvInfoDKHP.AllowUserToDeleteRows = false;
            this.dgvInfoDKHP.AllowUserToOrderColumns = true;
            this.dgvInfoDKHP.AllowUserToResizeColumns = false;
            this.dgvInfoDKHP.AllowUserToResizeRows = false;
            this.dgvInfoDKHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoDKHP.Location = new System.Drawing.Point(6, 19);
            this.dgvInfoDKHP.Name = "dgvInfoDKHP";
            this.dgvInfoDKHP.ReadOnly = true;
            this.dgvInfoDKHP.RowHeadersVisible = false;
            this.dgvInfoDKHP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfoDKHP.Size = new System.Drawing.Size(380, 234);
            this.dgvInfoDKHP.TabIndex = 1;
            // 
            // gbInfoDKHP
            // 
            this.gbInfoDKHP.Controls.Add(this.dgvInfoDKHP);
            this.gbInfoDKHP.Location = new System.Drawing.Point(12, 214);
            this.gbInfoDKHP.Name = "gbInfoDKHP";
            this.gbInfoDKHP.Size = new System.Drawing.Size(392, 259);
            this.gbInfoDKHP.TabIndex = 11;
            this.gbInfoDKHP.TabStop = false;
            this.gbInfoDKHP.Text = "Thông tin phiếu ĐKHP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phiếu: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "MSSV: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Học kỳ: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Năm học: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày lập: ";
            // 
            // tbSoPhieu
            // 
            this.tbSoPhieu.Location = new System.Drawing.Point(88, 30);
            this.tbSoPhieu.Name = "tbSoPhieu";
            this.tbSoPhieu.ReadOnly = true;
            this.tbSoPhieu.Size = new System.Drawing.Size(100, 20);
            this.tbSoPhieu.TabIndex = 6;
            // 
            // tbMSSV
            // 
            this.tbMSSV.Location = new System.Drawing.Point(273, 30);
            this.tbMSSV.Name = "tbMSSV";
            this.tbMSSV.Size = new System.Drawing.Size(100, 20);
            this.tbMSSV.TabIndex = 7;
            // 
            // tbHocKy
            // 
            this.tbHocKy.Location = new System.Drawing.Point(88, 112);
            this.tbHocKy.Name = "tbHocKy";
            this.tbHocKy.ReadOnly = true;
            this.tbHocKy.Size = new System.Drawing.Size(100, 20);
            this.tbHocKy.TabIndex = 8;
            // 
            // tbNamHoc
            // 
            this.tbNamHoc.Location = new System.Drawing.Point(273, 112);
            this.tbNamHoc.Name = "tbNamHoc";
            this.tbNamHoc.ReadOnly = true;
            this.tbNamHoc.Size = new System.Drawing.Size(100, 20);
            this.tbNamHoc.TabIndex = 9;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(88, 69);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(99, 20);
            this.dtpNgayLap.TabIndex = 10;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.dtpNgayLap);
            this.gbInfo.Controls.Add(this.tbNamHoc);
            this.gbInfo.Controls.Add(this.tbHocKy);
            this.gbInfo.Controls.Add(this.tbMSSV);
            this.gbInfo.Controls.Add(this.tbSoPhieu);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Location = new System.Drawing.Point(12, 41);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(392, 167);
            this.gbInfo.TabIndex = 1;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin phiếu ĐKHP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttReset);
            this.groupBox1.Location = new System.Drawing.Point(763, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 50);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tuỳ chọn khác";
            // 
            // bttReset
            // 
            this.bttReset.Location = new System.Drawing.Point(18, 15);
            this.bttReset.Name = "bttReset";
            this.bttReset.Size = new System.Drawing.Size(71, 20);
            this.bttReset.TabIndex = 3;
            this.bttReset.Text = "Làm mới";
            this.bttReset.UseVisualStyleBackColor = true;
            this.bttReset.Click += new System.EventHandler(this.bttReset_Click);
            // 
            // fTraCuuDKHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1049, 663);
=======
            this.ClientSize = new System.Drawing.Size(972, 536);
            this.Controls.Add(this.groupBox1);
>>>>>>> c8a98dfb559dbc34296e565520c01f27918362c7
            this.Controls.Add(this.gbAccessDKHP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbInfoDKHP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fTraCuuDKHP";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fTraCuuDKHP_Load);
<<<<<<< HEAD
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
=======
>>>>>>> c8a98dfb559dbc34296e565520c01f27918362c7
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDKHP)).EndInit();
            this.gbAccessDKHP.ResumeLayout(false);
            this.gbAccessDKHP.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoDKHP)).EndInit();
            this.gbInfoDKHP.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDKHP;
        private System.Windows.Forms.GroupBox gbAccessDKHP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSoPhieuAccess;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMSSVAccess;
        private System.Windows.Forms.Button bttXoaMH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvInfoDKHP;
        private System.Windows.Forms.GroupBox gbInfoDKHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSoPhieu;
        private System.Windows.Forms.TextBox tbMSSV;
        private System.Windows.Forms.TextBox tbHocKy;
        private System.Windows.Forms.TextBox tbNamHoc;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttReset;
        private System.Windows.Forms.Button bttDKMH;
        private System.Windows.Forms.Button button1;
    }
}

