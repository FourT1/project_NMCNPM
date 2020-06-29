﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace QuanLyHocPhi
{
    public partial class SinhVienChuaDngHP : Form
    {
        public SinhVienChuaDngHP()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=.\THEHUNG1610;Initial Catalog=QLVDKHPVTHPSV;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("SELECT * FROM HocKy ", connection);
            var table = new DataTable();
            dap.Fill(table);
            cbHocKy.DisplayMember = "HocKy";
            cbHocKy.ValueMember = "MaHK";
            cbHocKy.DataSource = table;

            //cbNamHoc.DisplayMember = "TenNH";
            //cbNamHoc.ValueMember = "MaNH";
            //cbNamHoc.DataSource = table;


           
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //int MaNH = Convert.ToInt32(cbNamHoc.SelectedValue);
            //var dap1 = new SqlDataAdapter("SELECT MaCT,MaSV,SoTienDK,SoTienDaDong,SoTienConLai FROM CT_DS_CHUADONGHP WHERE MaNH = " + MaNH + " ", connection);
            //var table1 = new DataTable();
            //dap1.Fill(table1);
            //dtgvChuaDongHP.DataSource = table1;

        }
        private void label1_Click(object sender, EventArgs e)
        {
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int MaHK = Convert.ToInt32(cbHocKy.SelectedValue);
            var dap = new SqlDataAdapter("SELECT * FROM CT_DS_CHUADONGHP WHERE MaHK = "+MaHK+" ", connection);
            var table = new DataTable();
            dap.Fill(table);
            dtgvChuaDongHP.DataSource = table;
            dtgvChuaDongHP.AllowUserToAddRows = false;
            dtgvChuaDongHP.EditMode = DataGridViewEditMode.EditProgrammatically;
            //dtgvChuaDongHP.Sort(dtgvChuaDongHP.Columns("MaNH"), System.ComponentModel.ListSortDirection.Ascending);


        }
        private void comboBox1_SelectedValueChanged1(object sender, EventArgs e)
        {
           /* int MaNH = Convert.ToInt32(cbHocKy.SelectedValue);
            var dap1 = new SqlDataAdapter("SELECT MaCT,MaSV,SoTienDK,SoTienDaDong,SoTienConLai FROM CT_DS_CHUADONGHP WHERE MaNH = " + MaNH + " ", connection);
            var table1 = new DataTable();
            dap1.Fill(table1);
            dtgvChuaDongHP.DataSource = table1;*/
        }

        private void dtgvChuaDongHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //dtgvChuaDongHP.Sort(dtgvChuaDongHP.Columns("MaNH"), System.ComponentModel.ListSortDirection.Ascending);
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int MaNH = Convert.ToInt32(cbNamHoc.SelectedValue);
            //var dap = new SqlDataAdapter("SELECT MaNH FROM CT_DS_CHUADONGHP WHERE MaHK = " + MaNH + " ", connection);
            //var table = new DataTable();
            //dap.Fill(table);
            //dtgvChuaDongHP.DataSource = table;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btInPhieu_Click(object sender, EventArgs e)
        {
            ReportCDHP f = new ReportCDHP();
            
            f.ShowDialog();
          
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void rpViewer_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
