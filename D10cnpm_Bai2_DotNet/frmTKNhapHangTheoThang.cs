using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace D10cnpm_Bai2_DotNet
{
    public partial class frmTKNhapHangTheoThang : Form
    {
        public frmTKNhapHangTheoThang()
        {
            InitializeComponent();
        }

        private void frmTKNhapHangTheoThang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DemoQuanLyBanHangDataSet.tb_NhapHang' table. You can move, or remove it, as needed.
            this.tb_NhapHangTableAdapter.Fill(this.DemoQuanLyBanHangDataSet.tb_NhapHang);

            

            SetParameters(dtpFrom.Value, dtpTo.Value);
            this.reportViewer1.RefreshReport();
        }
        private void SetParameters(DateTime from, DateTime to)
        {
            ReportParameter[] rp = new ReportParameter[2];
            rp[0] = new ReportParameter("FromMonth");
            rp[1] = new ReportParameter("ToMonth");
            rp[0].Values.Add(from.ToString());
            rp[1].Values.Add(to.ToString());
            reportViewer1.LocalReport.SetParameters(rp);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SetParameters(dtpFrom.Value, dtpTo.Value);
            reportViewer1.RefreshReport();
        }
    }
}
