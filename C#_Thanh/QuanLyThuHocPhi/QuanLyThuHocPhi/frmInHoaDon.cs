using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuHocPhi
{
    public partial class frmInHoaDon : Form
    {
        String sMaNV, sUserName;
        public frmInHoaDon(String IDsv, String IDnv)
        {
            InitializeComponent();
            sMaNV = IDsv;
            sUserName = IDnv;
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            crystalReportViewer1.ReportSource = hd;
            hd.SetParameterValue("@id", sMaNV);



        }
    }
}
