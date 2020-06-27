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
namespace DKHP
{
    public partial class fDKHP : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6TDDS79;Initial Catalog=QLVDKHPVTHPSV;Integrated Security=True");
        public fDKHP()
        {
            InitializeComponent();
            tbNamHoc.Text = DateTime.Now.Year.ToString();
            int month = DateTime.Now.Month;
            if(month>=8 && month<=12)
            {
                tbHocKy.Text = 2.ToString();
            }
            else
            {
                tbHocKy.Text = 1.ToString();
            }

        }


        private void fDKHP_Load(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("SELECT * FROM Khoa", conn);
            var table = new DataTable();
            dap.Fill(table);
            dgvDSMHM.DataSource = table;
        }


        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fInfoDKHP_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbHocKy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
