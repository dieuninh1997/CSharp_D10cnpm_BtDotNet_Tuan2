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
    public partial class frmTKTonKho : Form
    {
        public frmTKTonKho()
        {
            InitializeComponent();
        }

        private void frmTKTonKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DemoQuanLyBanHangDataSet.tb_SanPham' table. You can move, or remove it, as needed.
            this.tb_SanPhamTableAdapter.Fill(this.DemoQuanLyBanHangDataSet.tb_SanPham);

            this.reportViewer1.RefreshReport();
        
        }
    }
}
