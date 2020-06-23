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
    public partial class ForgotPass : Form
    {
        public ForgotPass()
        {
            InitializeComponent();
        }
        String ID = "0123456789qwertyuiopasdfghjklzxcvbnm";
        Random rnd = new Random();
        String randomID(int i) {
            String a = "";
            for (int j = 0; j < i; j++)
            {
                a += ID[rnd.Next(ID.Length)];
            }
            return a;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            String a = randomID(9);
            String link = @"Data Source=(localdb)\Projects;Initial Catalog=QuanLyHocPhi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            try
            {
                using (SqlConnection conn = new SqlConnection(link))
                {
                    conn.Open();
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = "sp_resetmk";
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Parameters.AddWithValue("@id", tbUserName.Text);
                        comm.Parameters.AddWithValue("@sdt", tbSDT.Text);
                        comm.Parameters.AddWithValue("@cmt", tbCMT.Text);
                        comm.Parameters.AddWithValue("pass", a);
                        int ire = comm.ExecuteNonQuery();
                        if (ire >= 1)
                        {
                            MessageBox.Show("Mật khẩu của bạn đã được reset thành: " + a, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Thông tin tài khoản của bạn không đúng,Bạn vui lòng kiểm tra lại thông tin tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ForgotPass_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
