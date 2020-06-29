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
namespace DKHP
{
    public partial class fDKHP : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6TDDS79;Initial Catalog=QLHP;Integrated Security=True");
        public fDKHP()
        {
            InitializeComponent();
            // Set học kỳ, năm học theo thời gian
            tbNamHoc.Text = DateTime.Now.Year.ToString();
            int month = DateTime.Now.Month;
            if (month >= 8 && month <= 12)
            {
                tbHocKy.Text = 2.ToString();
            }
            else
            {
                tbHocKy.Text = 1.ToString();
            }
            //Set ID tăng dần
            SqlDataAdapter sda = new SqlDataAdapter("SELECT isnull(max(cast(MaDKHP as int)),0)+1 FROM DKHP", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            tbSoPhieu.Text = dt.Rows[0][0].ToString();

        }


        private void fDKHP_Load(object sender, EventArgs e)
        {


            //

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fInfoDKHP_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttXoaMonHoc_Click(object sender, EventArgs e)
        {
            var mamonhoc = this.dgvDSMDK.CurrentRow.Cells[0].Value.ToString();
            conn.Open();
            var cmd = new SqlCommand("delete_MH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mamh", SqlDbType.VarChar).Value = mamonhoc;
            cmd.ExecuteNonQuery();
            conn.Close();
            loadDSDK();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbHocKy_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttDKHP_Click(object sender, EventArgs e)
        {
            //Kiểm tra MSSV có tồn tại
            var namhoc = Convert.ToInt32(tbHocKy.Text);
            var cmd1 = new SqlCommand("SELECT MaSV From DKHP WHERE MaSV ='"+tbMSSV.Text+"' AND HocKy="+namhoc+" AND NamHoc='"+tbNamHoc.Text+"' ", conn);
            var datafill = new SqlDataAdapter(cmd1);
            var table = new DataTable();
            datafill.Fill(table);
            //

            
            if (table.Rows.Count > 0)
            {
                    MessageBox.Show("MSSV đã tồn tại", "Thông báo");
                    table.Clear();
            }
            else if (tbSoPhieu.Text == "" || tbMSSV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
            else
            {
                conn.Open();
                var cmd = new SqlCommand("create_DKHP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sophieu", SqlDbType.VarChar).Value = tbSoPhieu.Text;
                cmd.Parameters.Add("@masv", SqlDbType.VarChar).Value = tbMSSV.Text;
                cmd.Parameters.Add("@ngaylap", SqlDbType.SmallDateTime).Value = dtpNgayLap.Value;
                cmd.Parameters.Add("@hocky", SqlDbType.TinyInt).Value = Convert.ToInt32(tbHocKy.Text);
                cmd.Parameters.Add("@namhoc", SqlDbType.VarChar).Value = tbNamHoc.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Đăng ký thành công", "Thông báo");
            }
        }

        private void bttAccessDKHP_Click(object sender, EventArgs e)
        {
            if (tbSoPhieuAccess.Text == "" || tbMSSVAccess.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin.");
            }

            var cmd = new SqlCommand("access_DKHP", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sophieu", SqlDbType.VarChar).Value = tbSoPhieuAccess.Text;
            cmd.Parameters.Add("@masv", SqlDbType.VarChar).Value = tbMSSVAccess.Text;
            var dap = new SqlDataAdapter(cmd);
            var table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count != 0)
            {
                dgvDSMDK.DataSource = table;
            }
            else
            {
                MessageBox.Show("Không tồn tại phiếu ĐKHP, vui lòng kiểm tra lại");
            }


            var cmd1 = new SqlCommand("dsMonHocMo", conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("@HocKy", SqlDbType.TinyInt).Value = Convert.ToInt32(tbHocKy.Text);
            cmd1.Parameters.Add("@NamHoc", SqlDbType.NVarChar).Value = tbNamHoc.Text;
            cmd1.Parameters.Add("@masv", SqlDbType.NVarChar).Value = tbMSSVAccess.Text;
            var datafill = new SqlDataAdapter(cmd1);
            var tableDK = new DataTable();
            datafill.Fill(tableDK);
            if (tableDK.Rows.Count != 0)
            {
                dgvDSMHM.DataSource = tableDK;
            }
            else
            {
                MessageBox.Show("Không tồn tại phiếu ĐKHP, vui lòng kiểm tra lại");
            }


        }

        void loadDSDK()
        {
            var cmd = new SqlCommand("access_DKHP", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sophieu", SqlDbType.VarChar).Value = tbSoPhieuAccess.Text;
            cmd.Parameters.Add("@masv", SqlDbType.VarChar).Value = tbMSSVAccess.Text;
            var dap = new SqlDataAdapter(cmd);
            var table = new DataTable();
            dap.Fill(table);
            dgvDSMDK.DataSource = table;
            dgvDSMDK.Refresh();
        }

        private void dgvDSMHM_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }




        private void dgvDSMHM_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var mamonhoc = this.dgvDSMHM.CurrentRow.Cells[0].Value.ToString();
            conn.Open();
            var cmd = new SqlCommand("dangky_MH", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sophieu", SqlDbType.VarChar).Value = tbSoPhieuAccess.Text;
            cmd.Parameters.Add("@mamh", SqlDbType.VarChar).Value = mamonhoc;
            var checkDuplicateMonHoc = new SqlCommand("SELECT * FROM CT_DKHP WHERE MaDKHP = '"+tbSoPhieuAccess.Text+"' AND MaMH = '"+mamonhoc+"' ", conn);
            var temp = new SqlDataAdapter(checkDuplicateMonHoc);
            var tempTable = new DataTable();
            temp.Fill(tempTable);
            if (tempTable.Rows.Count > 0)
            {
                MessageBox.Show("Môn học đã được đăng ký, vui lòng thử lại", "Thông báo");
                tempTable.Clear();
                conn.Close();
            }
            else
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Đăng ký môn học thành công, đóng để đăng ký tiếp tục", "Thông báo");
                loadDSDK();
            }
            


        }
    }
}
