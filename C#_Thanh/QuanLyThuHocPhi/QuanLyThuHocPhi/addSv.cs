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

namespace QuanLyThuHocPhi
{
    public partial class addSv : Form
    {
        public addSv()
        {
            InitializeComponent();
        }
        String link = @"Data Source=(localdb)\Projects;Initial Catalog=QuanLyHocPhi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            
        private void addSv_Load(object sender, EventArgs e)
        {
            cbTT.Items.Add("Đã nộp");
            cbTT.Items.Add("Chưa nộp");
            cbKhoa.Items.Add("Công nghệ thông tin");
            cbHDT.Items.Add("Từ Xa");
            cbHDT.Items.Add("Sau đại học");
            cbHDT.Items.Add("Chính Quy");
            cbTT.Text = cbTT.Items[0].ToString();
            cbTT.Enabled = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(link))
                {
                    conn.Open();
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = "sp_selectmon";
                        comm.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter da = new SqlDataAdapter(comm))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //gọi hàm thêm sinh viên
            addsv();
            //duyệt hết datagridview (dgv) 
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                //ép kiểu cột thứ 0 của dgv thành boolean (true/false)
                //nếu cột đó có giá trị là true
                //gọi hàm thêm môn học đó vào bảng đăng kí
                if (Convert.ToBoolean(dr.Cells[0].Value) == true)
                {
                    addmon(tbMa.Text, dr.Cells[1].Value.ToString());
                }
            }
            //trả về giá trị dialog là ok
            this.DialogResult = DialogResult.OK;
            //ẩn form
            this.Hide();
            //giải phóng bộ nhớ
            this.Dispose();
        }
        private void addsv()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(link))
                {
                    conn.Open();
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = "sp_insertsv";
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Parameters.AddWithValue("@id", tbMa.Text);
                        comm.Parameters.AddWithValue("@ten", tbTen.Text);
                        comm.Parameters.AddWithValue("@lop", tbLop.Text);
                        comm.Parameters.AddWithValue("@he", cbHDT.Text);
                        comm.Parameters.AddWithValue("@tt", cbTT.Text);
                        comm.Parameters.AddWithValue("@khoa", cbKhoa.Text);
                        int ire = comm.ExecuteNonQuery();
                        if (ire < 1)
                        {
                            MessageBox.Show("Thêm không thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //thêm môn học 
        private void addmon(String IDsv, String IDmon)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(link))
                {
                    conn.Open();
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = "sp_addmon";
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Parameters.AddWithValue("@masv", IDsv);
                        comm.Parameters.AddWithValue("@mamon", IDmon);
                        int ire = comm.ExecuteNonQuery();
                        if (ire < 1)
                        {
                            MessageBox.Show("Thêm sinh viên không thành công!!");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Hide();
            this.Dispose();
        }
    }
}
