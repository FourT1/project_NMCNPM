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
using DKHP;
using WindowsFormsApp1;

namespace TraCuu_DKHP
{

    public partial class fTraCuuDKHP : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6TDDS79;Initial Catalog=QLHP;Integrated Security=True");
        
     
        public fTraCuuDKHP()
        {
            InitializeComponent();
            // Load sẵn danh sách phiếu ĐKHP
            
            // Nếu cả 2 tb rỗng, trả về danh sách
           
        }

        


        public void LoadDKHPOriginal()
        {
            var cmd = new SqlCommand("SELECT * FROM DKHP", conn);
            var dap = new SqlDataAdapter(cmd);
            var table = new DataTable();
            dap.Fill(table);
            dgvDKHP.DataSource = table;
        }

        public void fTraCuuDKHP_Load(object sender, EventArgs e)
        {
            LoadDKHPOriginal();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

<<<<<<< HEAD
        private void fTraCuuDKHP_Load(object sender, EventArgs e)
        {

        }
=======
        private void bttAccessDKHP_Click(object sender, EventArgs e)
        {

        }

        private void tbSoPhieuAccess_TextChanged(object sender, EventArgs e)
        {
                var querySoPhieuAccess = new SqlCommand("SELECT * From DKHP WHERE MaDKHP = @madkhp ", conn);
                querySoPhieuAccess.Parameters.Add("@madkhp", SqlDbType.VarChar).Value = tbSoPhieuAccess.Text;
                var datafill = new SqlDataAdapter(querySoPhieuAccess);
                var tableResultAccess = new DataTable();
                datafill.Fill(tableResultAccess);
                dgvDKHP.DataSource = tableResultAccess;
        }

        void fSoPhieuAccess()
        {

        }

        private void tbMSSVAccess_TextChanged(object sender, EventArgs e)
        {
            if (tbSoPhieuAccess.Text == "")
            {
                var queryMaSVAccess = new SqlCommand("SELECT * From DKHP WHERE MaSV = @masv ", conn);
                queryMaSVAccess.Parameters.Add("@masv", SqlDbType.VarChar).Value = tbMSSVAccess.Text;
                var datafill = new SqlDataAdapter(queryMaSVAccess);
                var tableResultAccess = new DataTable();
                datafill.Fill(tableResultAccess);
                dgvDKHP.DataSource = tableResultAccess;
            }
        }

        private void bttReset_Click(object sender, EventArgs e)
        {
            tbMSSVAccess.Clear();
            tbSoPhieuAccess.Clear();
            LoadDKHPOriginal();
            
        }

        private void dgvDKHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvDKHP.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                
                    dgvDKHP.CurrentRow.Selected = true;
                    tbSoPhieu.Text = dgvDKHP.Rows[e.RowIndex].Cells[0].Value.ToString();
                    tbMSSV.Text = dgvDKHP.Rows[e.RowIndex].Cells[1].Value.ToString();
                    dtpNgayLap.Value = Convert.ToDateTime(dgvDKHP.Rows[e.RowIndex].Cells[2].Value);
                    tbHocKy.Text = dgvDKHP.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbNamHoc.Text = dgvDKHP.Rows[e.RowIndex].Cells[4].Value.ToString();
            }

            //Load bảng DSMDK
            var cmd = new SqlCommand("access_DKHP", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sophieu", SqlDbType.VarChar).Value = tbSoPhieu.Text;
            cmd.Parameters.Add("@masv", SqlDbType.VarChar).Value = tbMSSV.Text;
            var dap = new SqlDataAdapter(cmd);
            var table = new DataTable();
            dap.Fill(table);
            dgvInfoDKHP.DataSource = table;
            dgvInfoDKHP.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var mamonhoc = this.dgvInfoDKHP.CurrentRow.Cells[0].Value.ToString();
            conn.Open();
            var cmd = new SqlCommand("delete_MH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mamh", SqlDbType.VarChar).Value = mamonhoc;
            cmd.ExecuteNonQuery();
            conn.Close();
            loadDSDK();
        }

        void loadDSDK()
        {
            var cmd = new SqlCommand("access_DKHP", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sophieu", SqlDbType.VarChar).Value = tbSoPhieu.Text;
            cmd.Parameters.Add("@masv", SqlDbType.VarChar).Value = tbMSSV.Text;
            var dap = new SqlDataAdapter(cmd);
            var table = new DataTable();
            dap.Fill(table);
            dgvInfoDKHP.DataSource = table;
            dgvInfoDKHP.Refresh();
        }
        
        private void bttDKMH_Click(object sender, EventArgs e)
        {
            if (tbMSSV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu DKHP");
            }
            else
            {
                fTraCuuDKHP_DKMH frm2 = new fTraCuuDKHP_DKMH(tbMSSV.Text, tbNamHoc.Text, tbHocKy.Text, tbSoPhieu.Text);
                frm2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("access_DKHP", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sophieu", SqlDbType.VarChar).Value = tbSoPhieu.Text;
            cmd.Parameters.Add("@masv", SqlDbType.VarChar).Value = tbMSSV.Text;
            var dap = new SqlDataAdapter(cmd);
            var table = new DataTable();
            dap.Fill(table);
            dgvInfoDKHP.DataSource = table;
            dgvInfoDKHP.Refresh();
        }
>>>>>>> c8a98dfb559dbc34296e565520c01f27918362c7
    }
}
