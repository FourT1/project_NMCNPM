using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuHocPhi
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        String id = string.Empty;
        public ChangePassword(string a)
        {
            InitializeComponent();
            id = a;
            if (!string.IsNullOrEmpty(id))
            {
                tbUserName.Text = a;
                tbOldPass.Focus();
            }
            
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Regex regUsername = new Regex("^[0-9a-zA-Z_]{6,50}$");
            Match mUsernamePass = regUsername.Match(tbUserName.Text);
            if (string.IsNullOrWhiteSpace(tbUserName.Text))
            {
                errorProvider1.SetError(tbUserName, "Tên đăng nhập không được để trống!!");
                btnAccept.Enabled = false;
            }
            else if (tbUserName.Text.Trim().Length < 6)
            {
                errorProvider1.SetError(tbUserName, "Tên đăng nhập không được ít hơn 6 kí tự!!");
                btnAccept.Enabled = false;
            }
            else if (!mUsernamePass.Success)
            {
                errorProvider1.SetError(tbUserName, "Tên đăng nhập không được chứa kí tự đặc biệt!!");
                btnAccept.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(tbUserName ,string.Empty);
                btnAccept.Enabled = true;
            }
        }
        private void changepass()
        {
            
            try
            {
                String link = @"Data Source=(localdb)\Projects;Initial Catalog=QuanLyHocPhi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
                using (SqlConnection conn = new SqlConnection(link))
                {
                    conn.Open();
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = "sp_changemk";
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Parameters.AddWithValue("@id", tbUserName.Text);
                        comm.Parameters.AddWithValue("@pass", tbOldPass.Text);
                        comm.Parameters.AddWithValue("@newpass", tbNewPass.Text);
                        int ire = comm.ExecuteNonQuery();
                        if (ire < 1)
                        {
                            MessageBox.Show("Đổi mật khẩu không thành công,Bạn vui lòng kiểm tra lại thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Đổi mật khẩu thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetform();
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
        private void resetform()
        {
            tbUserName.Text = string.Empty;
            tbOldPass.Text = string.Empty;
            tbNewPass.Text = string.Empty;
            tbCheckNew.Text = string.Empty;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (tbNewPass.Text == tbCheckNew.Text)
            {
                changepass();
            }
            else
            {
                MessageBox.Show("bạn vui lòng xác nhận lại mật khẩu mới!!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCheckNew.Focus();
            }
        }
    }
}
