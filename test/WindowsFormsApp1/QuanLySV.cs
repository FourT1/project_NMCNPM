﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class QuanLySV : Form
    {
        public QuanLySV()
        {
            InitializeComponent();
        }
        SqlCommand command;
        SqlConnection conn = new SqlConnection(@"Data Source=FOURT1\THANHTUAN;Initial Catalog=QLHP;Integrated Security=True");
        // Boolean addSV = false;
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        
        //// hàm load data 
        void loaddata()
        {
           command = conn.CreateCommand();
           command.CommandText = "select * from SinhVien";
            adapter.SelectCommand = command;
            table.Clear();
              adapter.Fill(table);
            dgvSV.DataSource = table;
       }
        public bool checkInput()
        {
            if (string.IsNullOrEmpty(tbMSSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập MSSV", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QuanLySV_Load(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("SELECT * FROM Khoa", conn);
            var table = new DataTable();
            dap.Fill(table);
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "MaKhoa";
            cbbKhoa.DataSource = table;
            /*
             nếu code trên không chạy đc->> dùng code dưới đây
                 conn = new SqlConnection(str);
                 conn.Open();
                 loaddata();
             */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Khi bắt sự kiện xóa thì thêm dòng này 
            tbMSSV.ReadOnly = true;
            int i;
            i = dgvSV.CurrentRow.Index;
            tbMSSV.Text = dgvSV.Rows[i].Cells[0].Value.ToString();
            tbTen.Text = dgvSV.Rows[i].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvSV.Rows[i].Cells[2].Value.ToString();
            cbbbGioiTinh.Text = dgvSV.Rows[i].Cells[3].Value.ToString();
            cbbMaHuyen.Text = dgvSV.Rows[i].Cells[4].Value.ToString();
            cbbMaTinh.Text = dgvSV.Rows[i].Cells[5].Value.ToString();
            cbbNganh.Text = dgvSV.Rows[i].Cells[6].Value.ToString();
            cbbDoiTuong.Text = dgvSV.Rows[i].Cells[7].Value.ToString();
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mssv = cbbKhoa.SelectedValue.ToString();
            var dap = new SqlDataAdapter("SELECT TenKhoa FROM Khoa", conn);
            var table = new DataTable();
            dap.Fill(table);
        }
        ///
        private void button2_Click(object sender, EventArgs e)
        {
            //btnDel
            command = conn.CreateCommand();
            command.CommandText = ( " delete from SinhVien where MaSV = '"+tbMSSV+"' " );
            command.ExecuteNonQuery();
            loaddata();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            command.CommandText = "Insert into SINHVIEN values('"+tbMSSV.Text+"', '"+tbTen.Text+" , '"+dtpNgaySinh.Text+"', '"+cbbbGioiTinh.Text+"', '"+ cbbMaHuyen.Text+"' , '"+cbbMaTinh.Text+"' ,'" + cbbNganh.Text+"' ,'"+cbbDoiTuong.Text+"' )";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //chỉnh nút sửa 
            command = conn.CreateCommand();
            command.CommandText = "update MaSV set '"+tbTen.Text+"', NgaySinh = '"+ dtpNgaySinh.Text+"' , GioiTinh='"+cbbbGioiTinh.Text+"', MaHuyen='"+cbbMaHuyen.Text+"', MaTinh = '"+cbbMaTinh.Text+", MaNganh='"+cbbNganh.Text+"', '"+cbbDoiTuong.Text+"'";
            command.ExecuteNonQuery();
            loaddata();

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
