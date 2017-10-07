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
    public partial class fromNhapHang : Form
    {
        NhapHangBUS bus = new NhapHangBUS();

        public fromNhapHang()
        {
            InitializeComponent();
        }

        private void fromNhapHang_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        public void HienThi()
        {
             var dt = bus.GetData();
                        dgvNhapHang.DataSource = dt;
                     //   var soNhapHang = dt.Rows.Count;
                       // if (soNhapHang > 0)
                       ////     MessageBox.Show("Ket noi thang cong tb_NhapHang");
                       // else
                          //  MessageBox.Show("Ket noi failed tb_NhapHang");
        }
    }
}
