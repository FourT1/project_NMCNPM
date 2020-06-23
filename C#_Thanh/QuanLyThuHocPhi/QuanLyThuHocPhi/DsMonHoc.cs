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
    public partial class DsMonHoc : Form
    {

        private bool checkadd = false;
        private bool checkfix = false;
        public DsMonHoc()
        {
            InitializeComponent();
            loadform();
        }
        private String link = @"Data Source=(localdb)\Projects;Initial Catalog=QuanLyHocPhi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            
        private void loadform()
        {
            tbGV.Enabled = false;
            tbGia.Enabled = false;
            tbID.Enabled = false;
            tbName.Enabled = false;
            tbTinchi.Enabled = false;
            btnSave.Enabled = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(link))
                {
                    conn.Open();
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = "sp_selectmon";
                        comm.CommandType = CommandType.StoredProcedure;
                        comm.Connection = conn;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            checkadd = true;
            tbGV.Enabled = true;
            tbGia.Enabled = true;
            tbID.Enabled = true;
            tbName.Enabled = true;
            tbTinchi.Enabled = true;
            btnSave.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            checkfix = true;
            btnThem.Enabled = false;
            tbGV.Text = dataGridView1.SelectedCells[2].Value.ToString();
            tbID.Text = dataGridView1.SelectedCells[0].Value.ToString();
            tbName.Text = dataGridView1.SelectedCells[1].Value.ToString();
            tbTinchi.Text = dataGridView1.SelectedCells[3].Value.ToString();
            tbGia.Text = dataGridView1.SelectedCells[4].Value.ToString();
            tbGV.Enabled = true;
            tbGia.Enabled = true;
            tbID.Enabled = true;
            tbName.Enabled = true;
            tbTinchi.Enabled = true;
            tbID.Enabled = false;
            btnSua.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkadd == true)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(link))
                    {
                        conn.Open();
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandText = "sp_addmonhoc";
                            comm.CommandType = CommandType.StoredProcedure;
                            comm.Parameters.AddWithValue("@idmon", tbID.Text);
                            comm.Parameters.AddWithValue("@tenmon", tbName.Text);
                            comm.Parameters.AddWithValue("@tinchi", tbTinchi.Text);
                            comm.Parameters.AddWithValue("@gia", tbGia.Text);
                            comm.Parameters.AddWithValue("@tengv", tbGV.Text);
                            int ire = comm.ExecuteNonQuery();
                            if (ire < 1)
                            {
                                MessageBox.Show("Thêm mới thất bại");
                            }
                            else
                            {
                                loadform();
                                checkadd = false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                            comm.CommandText = "sp_updatemon";
                            comm.CommandType = CommandType.StoredProcedure;
                            comm.Parameters.AddWithValue("@idmon", tbID.Text);
                            comm.Parameters.AddWithValue("@tenmon", tbName.Text);
                            comm.Parameters.AddWithValue("@tinchi", tbTinchi.Text);
                            comm.Parameters.AddWithValue("@gia", tbGia.Text);
                            comm.Parameters.AddWithValue("@tengv", tbGV.Text);
                            int ire = comm.ExecuteNonQuery();
                            if (ire < 1)
                            {
                                MessageBox.Show("Update Thất Bại");
                            }
                            else
                            {
                                loadform();
                                checkfix = false;
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
    }
}
