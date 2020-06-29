using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NhapCThoc
{
    public partial class fNhapCTHoc : Form
    {
        public fNhapCTHoc()
        {
            InitializeComponent();
        }
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-E1G9U7V\NTHUNG;Initial Catalog=QLVDKHPVTHPSV;Integrated Security=True");
        SqlCommand command;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-E1G9U7V\NTHUNG;Initial Catalog=QLHP;Integrated Security=True");
        // Boolean addSV = false;
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = (@"Data Source=DESKTOP-E1G9U7V\NTHUNG;Initial Catalog=QLHP;Integrated Security=True");

        private void FNhapCTHoc_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
        }

        void loaddata()
        {
            command = conn.CreateCommand();
            command.CommandText = "SELECT MaCTH, TenNganh, HocKy, MaMH  FROM CTHOC INNER JOIN CT_CTHOC ON CTHOC.MaCTH = CT_CTHOC.MaCTH INNER JOIN Nganh ON CTHOC.MaNganh = Nganh.MaNganh ";//do phải inner join 3 bảng CTHoc, CT_CTHoc, Nganh mới có đủ thuộc tính để đổ vào datagridview
            adapter.SelectCommand = command;
            var table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            dgvCTHoc.DataSource = table;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvCTHoc.CurrentRow.Index;
            tbMaCTHoc.Text = dgvCTHoc.Rows[i].Cells[0].Value.ToString();
            cbbNganh.Text = dgvCTHoc.Rows[i].Cells[1].Value.ToString();
            tbHocKi.Text = dgvCTHoc.Rows[i].Cells[2].Value.ToString();
            tbMaMonHoc.Text = dgvCTHoc.Rows[i].Cells[3].Value.ToString();
            tbGhiChu.Text = dgvCTHoc.Rows[i].Cells[4].Value.ToString();
        }

        private void CbbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mssv = cbbKhoa.SelectedValue.ToString();
            var dap = new SqlDataAdapter("SELECT TenNganh FROM Nganh", conn);
            var table = new DataTable();
            dap.Fill(table);
        }

        private void CbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mssv = cbbKhoa.SelectedValue.ToString();
            var dap = new SqlDataAdapter("SELECT TenKhoa FROM Khoa", conn);
            var table = new DataTable();
            dap.Fill(table);
        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        private void BtThemCTHoc_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            command.CommandText = "Insert into CTHOC INNER JOIN CT_CTHOC ON CTHOC.MaCTH = CT_CTHOC.MaCTH INNER JOIN Nganh ON CTHOC.MaNganh = Nganh.MaNganh    (MaCTH, TenNganh, HocKy, MaMH) values('" + tbMaCTHoc.Text + "', '" + cbbNganh.Text + "' , '" + tbHocKi.Text + "', '" + tbMaMonHoc.Text + "' )";//Ghi chú thêm vào bảng nào?
            command.ExecuteNonQuery();//hàm này để xử lý câu truy vấn trên, nếu sai sẽ báo lỗi
            loaddata();//truy vấn xong load lại dữ liệu
        }

        private void TbMaCTHoc_TextChanged(object sender, EventArgs e)
        {

        }


        private void BtXoaCTHoc_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            command.CommandText = "delete from CTHOC INNER JOIN CT_CTHOC ON CTHOC.MaCTH = CT_CTHOC.MaCTH INNER JOIN Nganh ON CTHOC.MaNganh = Nganh.MaNganh    WHERE MaMH = '" + tbMaMonHoc.Text + "'";// xóa theo mã môn học
            command.ExecuteNonQuery();
            loaddata();
        }

        private void BtSuaCTHoc_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            command.CommandText = "UPDATE    CTHOC INNER JOIN CT_CTHOC ON CTHOC.MaCTH = CT_CTHOC.MaCTH INNER JOIN Nganh ON CTHOC.MaNganh = Nganh.MaNganh      SET MaCTH = '" + tbMaCTHoc.Text + "', TenNganh = N'" + cbbNganh.Text + "', HocKy =" + tbHocKi.Text + "  WHERE MaMH = '" + tbMaMonHoc.Text + "'  ";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
