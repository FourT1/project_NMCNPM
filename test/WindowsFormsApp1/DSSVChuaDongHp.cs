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
using System.Data.SqlTypes;


namespace ChuaDongHP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=.\THEHUNG1610;Initial Catalog=QLVDKHPVTHPSV;Integrated Security=True");
        private void lbHocKy_Click(object sender, EventArgs e)
        {

        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int MaHK = Convert.ToInt32(cbHocKy.SelectedValue);
            var dap = new SqlDataAdapter("SELECT MaNH AS NĂM_HỌC ,MaSV ,SoTienDK AS SỐ_TIỀN_ĐĂNG_KÝ ,SoTienDaDong AS SỐ_TIỀN_ĐÃ_ĐÓNG,SoTienConLai AS SỐ_TIỀN_CÒN_LẠI FROM CT_DS_CHUADONGHP WHERE MaHK = " + MaHK + " ", connection);
            var table = new DataTable();
            dap.Fill(table);
            dtgvChuaDongHP.DataSource = table;
            dtgvChuaDongHP.AllowUserToAddRows = false;
            dtgvChuaDongHP.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("SELECT * FROM HocKy ", connection);
            var table = new DataTable();
            dap.Fill(table);
            cbHocKy.DisplayMember = "HocKy";
            cbHocKy.ValueMember = "MaHK";
            cbHocKy.DataSource = table;
        }
    }
}
