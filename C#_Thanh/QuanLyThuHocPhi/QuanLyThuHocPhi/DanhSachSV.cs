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
    public partial class DanhSachSV : Form
    {
        //string link tới sql
        private static String link = @"Data Source=(localdb)\Projects;Initial Catalog=QuanLyHocPhi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        //string ten proc tra cuu
        private static String tracuu = @"sp_selectsv";
        //check sửa
        bool checkSua = false;
        //check them
        //check timkiem
        bool checktk = false;
        //check back
        bool checkback = false;
        /// <summary>
        /// reset các nút bấm trở về hiện trạng ban đầu
        /// </summary>
        private void reset()
        {
            cbHeDT.Enabled = false;
            cbKhoa.Enabled = false;
            tbLop.Enabled = false;
            tbMa.Enabled = false;
            tbTen.Enabled = false;
            cbTT.Enabled = false;
            btnSave.Enabled = false;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnThuTien.Enabled = true;
            btnDel.Enabled = true;
            listView1.Enabled = true;
            btnTimKiem.Enabled = true;
        }
        /// <summary>
        /// hiện các nút bấm
        /// </summary>
        private void enable()
        {
            cbHeDT.Enabled = true;
            cbKhoa.Enabled = true;
            tbLop.Enabled = true;
            tbMa.Enabled = true;
            tbTen.Enabled = true;
            cbTT.Enabled = true;
            btnSave.Enabled = true;
        }
        //lưu tên đăng nhập
        string username;
        //load dữ liệu cho combobox
        private void combobox()
        {
            cbTT.Items.Add("Đã nộp");
            cbTT.Items.Add("Chưa nộp");
            cbKhoa.Items.Add("Công nghệ thông tin");
            cbHeDT.Items.Add("Từ Xa");
            cbHeDT.Items.Add("Sau đại học");
            cbHeDT.Items.Add("Chính Quy");
        }
        public DanhSachSV(string a)
        {
            InitializeComponent();
            username = a;
            reset();
        }
        /// <summary>
        /// load dữ liệu cho form
        /// </summary>
        private void loadform(String tracuu)
        {
            
            try
            {
                using (SqlConnection conn = new SqlConnection(link))
                {
                    conn.Open();
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = tracuu;
                        comm.CommandType = CommandType.StoredProcedure;
                        SqlDataReader dr = comm.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                //i bằng số lượng iteam trong listview
                                int i = listView1.Items.Count;
                                listView1.Items.Add(dr["sMaSV"].ToString());
                                listView1.Items[i].SubItems.Add(dr["sTenSV"].ToString());
                                listView1.Items[i].SubItems.Add(dr["sLop"].ToString());
                                listView1.Items[i].SubItems.Add(dr["sHe"].ToString());
                                listView1.Items[i].SubItems.Add(dr["sTinhTrang"].ToString());
                                listView1.Items[i].SubItems.Add(dr["sKhoa"].ToString());
                            }
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
        /// tìm kiếm theo 1 hoặc nhiều thành phần
        /// </summary>
        private void timkiem()
        {
            //tạo string tìm kiếm
            string SelectQuery = "Select *  ";
            string FromQuery = "from tbl_sinhvien where ";
            if (tbMa.Text != "")
                FromQuery = FromQuery + "sMaSV like '" + tbMa.Text+ "'";
            if (tbTen.Text != "")
            {
                if (!string.IsNullOrWhiteSpace(tbMa.Text))
                { 
                    FromQuery = FromQuery + "And";
                }
                FromQuery = FromQuery + " sTenSV like N'" + tbTen.Text + "'";
            }
            if (tbLop.Text != "")
            {

                if (!string.IsNullOrWhiteSpace(tbMa.Text) || !string.IsNullOrWhiteSpace(tbTen.Text))
                { 
                    FromQuery = FromQuery + "And"; 
                }
                FromQuery = FromQuery  + " sLop like N'" + tbLop.Text + "'";
            }
            if (cbHeDT.Text != "")
            {
                if (!string.IsNullOrWhiteSpace(tbMa.Text) || !string.IsNullOrWhiteSpace(tbTen.Text) || !string.IsNullOrWhiteSpace(tbLop.Text))
                {
                    FromQuery = FromQuery + "And";
                }
                FromQuery = FromQuery  + " sHe like N'" + cbHeDT.Text + "'";
            }
            if (cbTT.Text != "")
            {
                if (!string.IsNullOrWhiteSpace(tbMa.Text) || !string.IsNullOrWhiteSpace(tbTen.Text) || !string.IsNullOrWhiteSpace(tbLop.Text) || !string.IsNullOrWhiteSpace(cbHeDT.Text))
                {
                    FromQuery = FromQuery + "And";
                }
                FromQuery = FromQuery + " sTinhTrang like N'" + cbTT.Text + "'";
            }
            if (cbKhoa.Text != "")
            {
                if (!string.IsNullOrWhiteSpace(tbMa.Text) || !string.IsNullOrWhiteSpace(tbTen.Text) || !string.IsNullOrWhiteSpace(tbLop.Text) || !string.IsNullOrWhiteSpace(cbHeDT.Text) || !string.IsNullOrWhiteSpace(cbTT.Text))
                {
                    FromQuery = FromQuery + "And";
                }
                FromQuery = FromQuery  + " sKhoa like N'" + cbKhoa.Text + "'";
            }
            string Query = SelectQuery + FromQuery;
            try
            {
                using (SqlConnection conn = new SqlConnection(link))
                {
                    conn.Open();
                    using (SqlCommand comm = new SqlCommand(Query,conn))
                    {
                        SqlDataReader dr = comm.ExecuteReader();
                        if (dr.HasRows)
                        {
                            listView1.Items.Clear();
                            while (dr.Read())
                            {
                                int i = listView1.Items.Count;
                                listView1.Items.Add(dr["sMaSV"].ToString());
                                listView1.Items[i].SubItems.Add(dr["sTenSV"].ToString());
                                listView1.Items[i].SubItems.Add(dr["sLop"].ToString());
                                listView1.Items[i].SubItems.Add(dr["sHe"].ToString());
                                listView1.Items[i].SubItems.Add(dr["sTinhTrang"].ToString());
                                listView1.Items[i].SubItems.Add(dr["sKhoa"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm","Tìm kiếm",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            addSv ad = new addSv();
            //nếu form ad trả về là ok thì load lại form
            if (ad.ShowDialog(this) == DialogResult.OK)
            {
                listView1.Items.Clear();
                loadform(tracuu);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            checkback = true;
            btnDel.Text = "Trở về";
            if (checktk == false)
            {
                //ẩn và hiện các nút sẽ dùng 
                btnSave.Enabled = false;
                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnDel.Enabled = true;
                btnThuTien.Enabled = true;
                //enable các textbox và combobox để tìm kiếm 
                tbMa.Enabled = true;
                tbTen.Enabled = true;
                tbLop.Enabled = true;
                cbKhoa.Enabled = true;
                cbTT.Enabled = false;
                cbHeDT.Enabled = true;
                //set text tk = true
                checktk = true;
                //đặt các textbox và combobox về rỗng để người dùng tìm kiếm
                tbMa.Text = string.Empty;
                tbTen.Text = string.Empty;
                tbLop.Text = string.Empty;
                cbKhoa.Text = string.Empty;
                cbTT.Text = string.Empty;
                cbHeDT.Text = string.Empty;

            }
            else
            {
                timkiem();
            }
        }

        private void DanhSachSV_Load(object sender, EventArgs e)
        {
            combobox();
            loadform(tracuu);
        }

        private void btnThuTien_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sinh viên để thanh toán!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                ThuTien tt = new ThuTien(tbMa.Text, username);
                if (tt.ShowDialog(this) == DialogResult.OK)
                {
                    listView1.Items.Clear();
                    loadform(tracuu);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check số lượng item đã chọn. nếu = 0 thì k làm gì hết (return; để thoát function)
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                tbMa.Text = listView1.SelectedItems[0].Text;
                tbTen.Text = listView1.SelectedItems[0].SubItems[1].Text;
                tbLop.Text = listView1.SelectedItems[0].SubItems[2].Text;
                cbHeDT.Text = listView1.SelectedItems[0].SubItems[3].Text;
                cbTT.Text = listView1.SelectedItems[0].SubItems[4].Text;
                cbKhoa.Text = listView1.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sinh viên để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                checkSua = true;
                enable();
                tbMa.Enabled = false;
                cbTT.Enabled = false;
                btnTimKiem.Enabled = false;
                btnDel.Enabled = false;
                btnThem.Enabled = false;
                btnThuTien.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkSua == true)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(link))
                    {
                        conn.Open();
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandText = "sp_fixsv";
                            comm.CommandType = CommandType.StoredProcedure;
                            comm.Parameters.AddWithValue("@id", tbMa.Text);
                            comm.Parameters.AddWithValue("@ten", tbTen.Text);
                            comm.Parameters.AddWithValue("@lop", tbLop.Text);
                            comm.Parameters.AddWithValue("@he", cbHeDT.Text);
                            comm.Parameters.AddWithValue("@tt", cbTT.Text);
                            comm.Parameters.AddWithValue("@khoa", cbKhoa.Text);
                            int ire = comm.ExecuteNonQuery();
                            if(ire < 1 )
                            {
                                MessageBox.Show("Sửa không thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                reset();
                                checkSua = false;
                                listView1.Items.Clear();
                                loadform(tracuu);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //đăng xuất
        private void ttDx_Click(object sender, EventArgs e)
        {
            //ẩn form
            this.Hide();
            //trả về result  = no
            this.DialogResult = DialogResult.No;
        }

        private void ttdmk_Click(object sender, EventArgs e)
        {
            ChangePassword cg = new ChangePassword(username);
            cg.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (checkback == true)
            {
                reset();
                listView1.Items.Clear();
                loadform(tracuu);
                checkback = false;
                checktk = false;
                btnDel.Text = "Xóa";
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(link))
                    {
                        conn.Open();
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandText = "sp_deletedk";
                            comm.CommandType = CommandType.StoredProcedure;
                            comm.Parameters.AddWithValue("@id", tbMa.Text);
                            int ire = comm.ExecuteNonQuery();
                            comm.CommandText = "sp_deletehd";
                            comm.ExecuteNonQuery();
                            comm.CommandText = "sp_delete";
                            int ire1 = comm.ExecuteNonQuery();
                            if (ire < 1 || ire1 < 1)
                            {
                                MessageBox.Show("Xóa không thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                reset();
                                listView1.Items.Clear();
                                loadform(tracuu);

                            }
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void thôngTinSinhViênTheoMãSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            tracuu = @"sp_selectsv";
            loadform(tracuu);
        }

        private void thôngTinSinhViênTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            tracuu = @"sp_selectlop";
            loadform(tracuu);
        }

        private void thôngTinSinhViênTheoTìnhTrạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            tracuu = @"sp_selecttt";
            loadform(tracuu);
        }

        private void thôngTinSinhViênTheoHệĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            tracuu = @"sp_selecthe";
            loadform(tracuu);
        }

        
        private void DanhSachSV_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVienInfor nv = new NhanVienInfor(username);
            nv.ShowDialog();
            nv.Dispose();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DsMonHoc ds = new DsMonHoc();
            this.Hide();
            if (ds.ShowDialog(this) == DialogResult.OK)
            {
                this.Show();
                ds.Dispose();
            }
            else
            {
                this.Close();
            }
        }


       
    }
}
