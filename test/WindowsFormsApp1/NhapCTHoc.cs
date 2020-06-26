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
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-E1G9U7V\NTHUNG;Initial Catalog=QLVDKHPVTHPSV;Integrated Security=True");
        private void FNhapCTHoc_Load(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("SELECT * FROM Khoa", conn);
            var table = new DataTable();
            dap.Fill(table);
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "MaKhoa";
            cbbKhoa.DataSource = table;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
