using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace D10cnpm_Bai2_DotNet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void menuNhapHang_Click(object sender, EventArgs e)
        {
            fromNhapHang frmNH = new fromNhapHang();
            frmNH.Show();
        }

        private void menuBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang frmBH = new frmBanHang();
            frmBH.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
        }

        private void menuTKNH_Click(object sender, EventArgs e)
        {
            frmTKNhapHangTheoThang tkNH = new frmTKNhapHangTheoThang();
            tkNH.Show();
        }

        private void menuTKBH_Click(object sender, EventArgs e)
        {
            frmTKBanHangTheoThang tkBh = new frmTKBanHangTheoThang();
            tkBh.Show();
        }

        private void menuTKTonKho_Click(object sender, EventArgs e)
        {
            frmTKTonKho tkho = new frmTKTonKho();
            tkho.Show();
        }

        private void menuTKDoanhSo_Click(object sender, EventArgs e)
        {

        }
    }
}
