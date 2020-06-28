using System;
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
        SqlConnection conn = new SqlConnection(@"Data Source=FOURT1\THANHTUAN;Initial Catalog=QLVDKHPVTHPSV;Integrated Security=True");
        // Boolean addSV = false;
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = (@"Data Source=FOURT1\THANHTUAN;Initial Catalog=QLVDKHPVTHPSV;Integrated Security=True");
        // hàm load data 
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

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            command.CommandText = "Insert into SINHVIEN values('"+tbMSSV.Text+"', '"+tbTen.Text+" , '"+dtpNgaySinh.Text+"', '"+cbbbGioiTinh.Text+"', '"+ cbbMaHuyen.Text+"' , '"+cbbMaTinh.Text+"' ,'" + cbbNganh.Text+"' ,'"+cbbDoiTuong.Text+"' )";
            command.ExecuteNonQuery();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

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
