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
    public partial class ThuTien : Form
    {
        String IDsv, IDnv,NVName;
        public ThuTien(String Ma, String UserName)
        {
            InitializeComponent();
            IDsv = Ma;
            IDnv = UserName;
        }

        

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmInHoaDon hd = new frmInHoaDon(IDsv,IDnv);
            hd.ShowDialog();
        }
        private static String link = @"Data Source=(localdb)\Projects;Initial Catalog=QuanLyHocPhi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        private static double a = 0,b = 0;
        private void ThuTien_Load(object sender, EventArgs e)
        {
            btnTT.Enabled = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(link))
                {
                    conn.Open();
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.CommandText = "sp_SelectSvID";
                        comm.Parameters.AddWithValue("@id", IDsv);
                        SqlDataReader dr = comm.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                lbMasv.Text = dr["sMaSV"].ToString();
                                lbHoten.Text = dr["sTenSV"].ToString();
                                lbLop.Text = dr["sLop"].ToString();
                                lbHDT.Text = dr["sHe"].ToString();
                                lbKhoa.Text = dr["sKhoa"].ToString();
                                lbTT.Text = dr["sTinhTrang"].ToString();
                            }
                            dr.Close();
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu!!!");
                        }
                        comm.CommandText = "sp_TongTien";
                        dr = comm.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                lbTongTien.Text = dr["TT"].ToString();
                            }
                            dr.Close();
                            //lấy lại $ trước khi format
                            a = double.Parse(lbTongTien.Text);
                            // định dạng tổng tiền về dạng #,###,### VNĐ - {0:0,0 VNĐ}
                            lbTongTien.Text = String.Format("{0:0,0 VNĐ}", double.Parse(lbTongTien.Text)).ToString();
                        }
                        comm.CommandText = "sp_selectHD";
                        dr = comm.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                String c = "";
                                c = dr["mThanhToan"].ToString();
                                tbThanhToan.Text = string.Format("{0:0,0}", double.Parse(c));
                            }
                            
                        }
                        dr.Close();
                        if (lbTT.Text != "Đã nộp")
                        {
                            btnIn.Enabled = false;
                        }
                        comm.CommandText = "sp_NguoiLap";
                        comm.Parameters.Clear();
                        comm.Parameters.AddWithValue("@manv", IDnv);
                        dr = comm.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                NVName = dr["sTenNV"].ToString();
                            }
                        }
                        dr.Close();
                        
                    }

                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.CommandText = "sp_LayMonHoc";
                        comm.Parameters.AddWithValue("@id", IDsv);
                        //tạo 1 dataadapter để lấy dữ liệu
                        using (SqlDataAdapter dt = new SqlDataAdapter(comm))
                        {
                            //tạo datatable để đổ dữ liệu vào
                            DataTable dt = new DataTable();
                            //đổ dữ liệu vào datatable
                            da.Fill(dt);
                            //đặt datasource cho datagridview
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

        private void btnTT_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(link))
                {
                    conn.Open();
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.CommandText = "sp_insertHD";
                        comm.Parameters.AddWithValue("@masv", lbMasv.Text);
                        comm.Parameters.AddWithValue("@tongtien", a);
                        comm.Parameters.AddWithValue("@thanhtoan ", double.Parse(tbThanhToan.Text));
                        comm.Parameters.AddWithValue("@ngaylap",DateTime.Now);
                        comm.Parameters.AddWithValue("@nguoilap", NVName);
                        int ire = comm.ExecuteNonQuery();
                        if(ire<1)
                        {
                            MessageBox.Show("Thêm mới HD không thành công!!");
                            return;
                        }
                        //khai báo commandText mới
                        comm.CommandText = "sp_ThanhToan";
                        //clear tất cả parameter và add parameter mới
                        comm.Parameters.Clear();
                        comm.Parameters.AddWithValue("@id", lbMasv.Text);
                        ire = comm.ExecuteNonQuery();
                        if (ire < 1)
                        {
                            MessageBox.Show("Thêm mới HD không thành công!!");
                            return;
                        }
                        else
                        {
                            lbTT.Text = "Đã nộp";
                            btnIn.Enabled = true;
                            btnTT.Enabled = false;
                            MessageBox.Show("Thanh toán thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbThanhToan_Leave(object sender, EventArgs e)
        {
            Regex regTienThanhToan = new Regex("^[0-9_]{0,10}$");
            Match mThanhToan = regTienThanhToan.Match(tbThanhToan.Text);
            //kiểm tra xem kí tự nhập vào có phải là chữ số hay không
            //nếu không thì báo lỗi và ẩn nút thanh toán 
            if (!mThanhToan.Success)
            {
                errorProvider1.SetError(tbThanhToan, "Tiền thanh toán không được chứa chữ hoặc kí tự đặc biệt!!");
                btnTT.Enabled = false;
            }
            //nếu đúng thì lưu lại số tiền đã nhập vào b
            //format dạng tiền nhập vào về dạng x.xxx.xxx
            if (mThanhToan.Success)
            {
                b = double.Parse(tbThanhToan.Text);
                tbThanhToan.Text = String.Format("{0:0,0}", double.Parse(tbThanhToan.Text)).ToString();
                btnTT.Enabled = true;
                errorProvider1.SetError(tbThanhToan, string.Empty);
            }
            //nếu số tiền nhập vào lớn hơn số tiền phải thanh toán
            //tự động chuyển số tiền nhập vào về bằng với số tiền phải thanh toán và format
            if(mThanhToan.Success && b>a )
            {
                tbThanhToan.Text = String.Format("{0:0,0}", a).ToString();
                btnTT.Enabled = true;
                errorProvider1.SetError(tbThanhToan, string.Empty);
            }
            //kiểm tra số tiền nộp có bằng số tiền phải thanh toán hay không
            //nếu số tiền nhập vào nhỏ hơn số tiền phải thanh toán thì hiện thông báo ( không cho nợ học phí )
            if (mThanhToan.Success && b < a)
            {
                MessageBox.Show("Bạn chưa nộp đủ tiền. vui lòng kiểm tra lại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btnTT.Enabled = false;
                btnIn.Enabled = false;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            //ẩn form và trả về result là ok rồi giải phóng form
            this.Hide();
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void ThuTien_FormClosing(object sender, FormClosingEventArgs e)
        {
            //trả về result là ok và đóng form
            this.DialogResult = DialogResult.OK;
        }

       
        
    }
}
