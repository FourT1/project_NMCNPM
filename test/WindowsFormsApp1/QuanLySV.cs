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
        SqlConnection conn = new SqlConnection(@"Data Source=FOURT1\THANHTUAN;Initial Catalog=QLVDKHPVTHPSV;Integrated Security=True");
        Boolean addSV = false;
        private void button1_Click(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
