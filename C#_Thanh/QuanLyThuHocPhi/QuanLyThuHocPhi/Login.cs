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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       
        /// <summary>
        /// hàm kiểm soát nhập UserName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbLogin_Validating(object sender, CancelEventArgs e)
        {
            Regex regUsername = new Regex("^[0-9a-zA-Z_]{6,50}$");
            Match mUsernamePass = regUsername.Match(tbLogin.Text);
            if (string.IsNullOrWhiteSpace(tbLogin.Text))
            {
                errorProvider1.SetError(tbLogin, "Tên đăng nhập không được để trống!!");
                btnLogin.Enabled = false;
            }
            else if(tbLogin.Text.Trim().Length <6)
            {
                errorProvider1.SetError(tbLogin, "Tên đăng nhập không được ít hơn 6 kí tự!!");
                btnLogin.Enabled = false;
            }
            else if (!mUsernamePass.Success)
            {
                errorProvider1.SetError(tbLogin, "Tên đăng nhập không được chứa kí tự đặc biệt!!");
                btnLogin.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(tbLogin, string.Empty);
                btnLogin.Enabled = true;
            }
        }
        /// <summary>
        /// hàm kiểm soát nhập mật khẩu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPass_Validating(object sender, CancelEventArgs e)
        {
            Regex regUsername = new Regex("^[0-9a-zA-Z_]{6,15}$");
            Match mUsernamePass1 = regUsername.Match(tbPass.Text);
            if (string.IsNullOrWhiteSpace(tbPass.Text))
            {
                errorProvider2.SetError(tbPass, "Mật khẩu không được để trống!!");
                btnLogin.Enabled = false;
            }
            else if (tbPass.Text.Trim().Length < 6)
            {
                errorProvider2.SetError(tbPass, "Mật khẩu không được ít hơn 6 kí tự!!");
                btnLogin.Enabled = false;
            }
            else if (!mUsernamePass1.Success)
            {
                errorProvider2.SetError(tbPass, "Mật khẩu không được chứa kí tự đặc biệt!!");
                btnLogin.Enabled = false;
            }
            else
            {
                errorProvider2.SetError(tbPass, string.Empty);
                btnLogin.Enabled = true;

            }
        }
        /// <summary>
        /// Thoát chương trình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Đăng nhập vào chương trình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
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
                        comm.CommandText = "sp_login";
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Parameters.AddWithValue("@id", tbLogin.Text);
                        comm.Parameters.AddWithValue("@pass", tbPass.Text);
                        //chỉ đọc k được sửa hay xóa
                        SqlDataReader dr =  comm.ExecuteReader();
                        if (dr.HasRows)
                        {
                            //mở form mới và đóng form login
                            DanhSachSV ds = new DanhSachSV(tbLogin.Text);
                            this.Hide();
                            //ds.show();
                            ds.ShowDialog();
                            if (ds.DialogResult == DialogResult.No)
                            {
                                //khi đăng xuất - result = no - clear 2 textbox và forcus vào tbLogin
                                this.Show();
                                tbLogin.Text = string.Empty;
                                tbPass.Text = string.Empty;
                                tbLogin.Focus();
                            }
                            else
                            {
                                //giải phóng bộ nhớ
                                this.Dispose();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập không thành công, bạn vui lòng kiểm tra lại tài khoản hoặc mật khẩu!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Bắn sự kiện khi ấn enter trong text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                btnLogin.Focus();
            }
        }
        /// <summary>
        /// Mở form ForgotPass
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbFogot_Click(object sender, EventArgs e)
        {
            ForgotPass fg = new ForgotPass();
            fg.ShowDialog();
        }

        private void lbChange_Click(object sender, EventArgs e)
        {
            ChangePassword cg = new ChangePassword();
            cg.ShowDialog();
        }
        
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lbTaoTK_Click(object sender, EventArgs e)
        {
            register dk = new register();
            dk.ShowDialog();
        }

        
    }
}
