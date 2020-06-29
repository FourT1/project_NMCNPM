using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class DSMonHoc : Form
    {
        public DSMonHoc()
        {
            InitializeComponent();
        }
        string chuoiketnoi= @"Data Source=DESKTOP-3TKLP15\SQLEXPRESS;Initial Catalog=LABMEM;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        // thêm 1 sinh viên 
        private void btnAdd_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"Insert into MONHOC (MaMH, TenMH, LoaiMon,SoTiet) VALUES (N'" + txtID.Text + @"',N'"+txtTen.Text+ @"', N'" +txtSoTiet.Text  +@"',N'" +cbbLoaiMon +@"')";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"UPDATE FROM  MONHOC SET MaMH= N '" + txtID.Text + @"', TenMH = N '" + txtSoTiet + @"', SoTiet = N '" + cbbLoaiMon + @"'
            WHERE ( MaMH = N'"+txtID.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"Delete from MONHOC where (MaMH = N'" + txtID.Text + @"')";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSoTiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void DSMonHoc_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            hienthi();
        }
        //hiển thị dữ liệu 
        public void hienthi()
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"Select MaMH,TenMH, LoaiMon from MONHOC";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listView1.Items.Add(docdulieu[0].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[1].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[2].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // khi nhấn vào form sẽ hiển thị ra thông tin trên bảng người dùng 
        private void listView1_Click(object sender, EventArgs e)
        {
            txtID.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtID.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtID.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtID.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
