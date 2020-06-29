using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraCuu_DKHP;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class fTraCuuDKHP_DKMH : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6TDDS79;Initial Catalog=QLHP;Integrated Security=True");
        public fTraCuuDKHP_DKMH(string MSSV, string NamHoc, string HocKy, string SoPhieu)
        {
            InitializeComponent();
            if (MSSV == "")
            {
                return;
            }
            else
            {
                var cmd1 = new SqlCommand("dsMonHocMo", conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add("@HocKy", SqlDbType.TinyInt).Value = Convert.ToInt32(HocKy);
                cmd1.Parameters.Add("@NamHoc", SqlDbType.NVarChar).Value = NamHoc;
                cmd1.Parameters.Add("@masv", SqlDbType.NVarChar).Value = MSSV;
                var datafill = new SqlDataAdapter(cmd1);
                var tableDK = new DataTable();
                datafill.Fill(tableDK);
                if (tableDK.Rows.Count != 0)
                {
                    dgvDSMHM.DataSource = tableDK;
                }
            }
        }

        private void dgvDSMHM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSMHM_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
