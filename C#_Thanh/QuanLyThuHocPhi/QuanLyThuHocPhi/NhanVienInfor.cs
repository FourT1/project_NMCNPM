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
    public partial class NhanVienInfor : Form
    {
        String sUserName;
        public NhanVienInfor(String IDnv)
        {
            InitializeComponent();
            sUserName = IDnv;
        }


        String link = @"Data Source=(localdb)\Projects;Initial Catalog=QuanLyHocPhi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NhanVienInfor_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(link))
                {
                    conn.Open();
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = "sp_selectNV";
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Parameters.AddWithValue("@id",sUserName);
                        SqlDataReader dr = comm.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                lbName.Text = dr["sTenNV"].ToString();
                                lbCMT.Text = dr["sCMT"].ToString();
                                lbSDT.Text = dr["sSDT"].ToString();
                            }
                        }
                        dr.Close();
                        //clear parameter đã truyền và add parameter mới
                        comm.Parameters.Clear();
                        comm.Parameters.AddWithValue("@nvName", lbName.Text);
                        comm.CommandText = "sp_countNV";
                        dr = comm.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                //"nv" là tên mình đặt bên proc khi select
                                lbSoHD.Text = dr["nv"].ToString();
                            }
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
