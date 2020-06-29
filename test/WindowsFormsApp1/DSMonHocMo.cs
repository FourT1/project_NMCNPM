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

//Cái mã MH mở chắc để nó tự động sinh là Mã + 
namespace DSMonHocMo
{
    public partial class DSMonHocMo : Form
    {
        public DSMonHocMo()
        {
            InitializeComponent();
        }

        SqlCommand command;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-E1G9U7V\NTHUNG;Initial Catalog=QLHP;Integrated Security=True");
        // Boolean addSV = false;
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = (@"Data Source=DESKTOP-E1G9U7V\NTHUNG;Initial Catalog=QLHP;Integrated Security=True");

        private void FDSMONHOCMO_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
        }

        void loaddata()
        {
            command = conn.CreateCommand();
            command.CommandText = "SELECT TenMH  FROM  FROM CTHOC INNER JOIN CT_CTHOC ON CTHOC.MaCTH = CT_CTHOC.MaCTH INNER JOIN MonHoc ON CT_CTHOC.MaMH = MonHoc.MaMH ";//do phải inner join 3 bảng CTHoc, CT_CTHoc, MonHoc mới có đủ thuộc tính để đổ vào datagridview
            adapter.SelectCommand = command;
            var table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            dgvDSMonHocMo.DataSource = table;//đổ dữ liệu vừa truy xuất vào datagridview
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mssv = cbHocKi.SelectedValue.ToString();
            var dap = new SqlDataAdapter("SELECT TenNganh FROM Nganh", conn);//không có bảng học kì thì lấy các giá trị combobox ở đâu?
            var table = new DataTable();
            dap.Fill(table);
        }

        private void dgvDSMonHocMo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
