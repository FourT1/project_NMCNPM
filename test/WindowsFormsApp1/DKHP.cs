﻿using System;
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
            tbNamHoc.Text = DateTime.Now.Year.ToString();
            int month = DateTime.Now.Month;
            if(month>=8 && month<=12)
            {
                tbHocKy.Text = 2.ToString();
            }
            else
            {
                tbHocKy.Text = 1.ToString();
            }

        }

        public delegate void UpdateDelegate(object sender, UpdateDelegate args);
        public event UpdateDelegate UpdateEventHandler;

            private void fDKHP_Load(object sender, EventArgs e)
        {

            var cmd = new SqlCommand("dsMonHocMo", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@HocKy", SqlDbType.TinyInt).Value = Convert.ToInt32(tbHocKy.Text);
            cmd.Parameters.Add("@NamHoc", SqlDbType.NVarChar).Value = tbNamHoc.Text;
            cmd.Parameters.Add("@masv", SqlDbType.NVarChar).Value = tbMSSV.Text;
            var dap = new SqlDataAdapter(cmd);
            var table = new DataTable();
            dap.Fill(table);
            dgvDSMHM.DataSource = table;
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

        private void bttAccessDKHP_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("access_DKHP", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@sophieu", SqlDbType.VarChar).Value = tbSoPhieuAccess.Text;
            cmd.Parameters.Add("@masv", SqlDbType.VarChar).Value = tbMSSVAccess.Text;
            var dap = new SqlDataAdapter(cmd);
            var table = new DataTable();
            dap.Fill(table);
            dgvDSMDK.DataSource = table;

            var cmd1 = new SqlCommand("dsMonHocMo", conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add("@HocKy", SqlDbType.TinyInt).Value = Convert.ToInt32(tbHocKy.Text);
            cmd1.Parameters.Add("@NamHoc", SqlDbType.NVarChar).Value = tbNamHoc.Text;
            cmd1.Parameters.Add("@masv", SqlDbType.NVarChar).Value = tbMSSVAccess.Text;
            var datafill = new SqlDataAdapter(cmd1);
            var tableDK = new DataTable();
            datafill.Fill(tableDK);
            dgvDSMHM.DataSource = tableDK;
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
            cmd.ExecuteNonQuery();
            conn.Close();
            
            MessageBox.Show("Đăng ký môn học thành công, đóng để đăng ký tiếp tục", "Thông báo");
            loadDSDK();
        }
    }
}
