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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            loadform();
        }
        String ID = "0123456789qwertyuiopasdfghjklzxcvbnm";
        Random rnd = new Random();
        String randomID(int i)
        {
            String a = "";
            for (int j = 0; j < i; j++)
            {
                a += ID[rnd.Next(ID.Length)];
            }
            return a;
        }
        String a;
        private void loadform()
        {
            lbCapcha.Text = randomID(6);
            a = lbCapcha.Text;
            tbCapcha.Text = string.Empty;
            tbCMT.Text = string.Empty;
            tbCheckPass.Text = string.Empty;
            tbPassword.Text = string.Empty;
            tbSDT.Text = string.Empty;
            tbTen.Text = string.Empty;
            tbUserName.Text = string.Empty;
            btnDangki.Enabled = false;
        }

        private void ResetCap()
        {
            lbCapcha.Text = randomID(6);
            a = lbCapcha.Text;
        }

        private void tbCheckPass_Leave(object sender, EventArgs e)
        {
            if (tbCheckPass.Text != tbPassword.Text)
            {
                errorProvider1.SetError(tbCheckPass, "Xác nhận mật khẩu không chính xác, vui lòng kiểm tra lại!!");
                btnDangki.Enabled = false;
                tbCheckPass.Text = string.Empty;
            }
            else
            {
                errorProvider1.SetError(tbCheckPass, string.Empty);
                checkbutton();
            }
        }
        private bool checkbutton()
        {
            if (tbCapcha.Text != string.Empty && tbCMT.Text != string.Empty && tbPassword.Text != string.Empty && tbSDT.Text != string.Empty && tbTen.Text != string.Empty && tbUserName.Text != string.Empty && tbCheckPass.Text != string.Empty)
            {
                btnDangki.Enabled = true;
                return true;
            }
            return false;
        }
        private void tbCapcha_Leave(object sender, EventArgs e)
        {
            if (tbCapcha.Text != a)
            {
                MessageBox.Show("Mã xác nhận không đúng, bạn vui lòng nhập lại mã xác nhận");
                ResetCap();
                tbCapcha.Text = string.Empty;
                btnDangki.Enabled = false;
            }
            else
            {
                if (!checkbutton()) btnDangki.Enabled = false;
            }
        }

        private void tbTen_Leave(object sender, EventArgs e)
        {
            if (!checkbutton()) btnDangki.Enabled = false;
        }

        private void tbSDT_Leave(object sender, EventArgs e)
        {
            if (!checkbutton()) btnDangki.Enabled = false;
        }

        private void tbCMT_Leave(object sender, EventArgs e)
        {
            if (!checkbutton()) btnDangki.Enabled = false;
        }

        private void tbUserName_Leave(object sender, EventArgs e)
        {
            if (!checkbutton()) btnDangki.Enabled = false;
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (!checkbutton()) btnDangki.Enabled = false;
        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            String link = @"Data Source=(localdb)\Projects;Initial Catalog=QuanLyHocPhi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            try
            {
                using (SqlConnection conn = new SqlConnection(link))
                {
                    conn.Open();
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = "sp_addnv";
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Parameters.AddWithValue("@username", tbUserName.Text);
                        comm.Parameters.AddWithValue("@password", tbPassword.Text);
                        comm.Parameters.AddWithValue("@tennv", tbTen.Text);
                        comm.Parameters.AddWithValue("@sdt", tbSDT.Text);
                        comm.Parameters.AddWithValue("@cmt", tbCMT.Text);
                        int ire = comm.ExecuteNonQuery();
                        if (ire < 1)
                        {
                            MessageBox.Show("Tạo tài khoản không thành công!!");
                        }
                        else
                        {
                            MessageBox.Show("Tạo tài khoản thành công!!");
                            this.Dispose();
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
            this.Dispose();
        }

    }
}
