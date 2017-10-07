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
    public partial class frmTKBanHangTheoThang : Form
    {
        public frmTKBanHangTheoThang()
        {
            InitializeComponent();
        }

        private void frmTKBanHangTheoThang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DemoQuanLyBanHangDataSet.view_HienThiTatCa' table. You can move, or remove it, as needed.
            this.view_HienThiTatCaTableAdapter.Fill(this.DemoQuanLyBanHangDataSet.view_HienThiTatCa);

            this.reportViewer1.RefreshReport();
        }
    }
}
