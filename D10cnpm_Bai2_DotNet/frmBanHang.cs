using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace D10cnpm_Bai2_DotNet
{
    public partial class frmBanHang : Form
    {

        HoaDonBUS busHD = new HoaDonBUS();
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        public void HienThi()
        {
            var dt = busHD.GetData();
            dgvBanHang.DataSource = dt;
          
        }
    }
}
