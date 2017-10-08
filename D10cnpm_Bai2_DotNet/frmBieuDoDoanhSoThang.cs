using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace D10cnpm_Bai2_DotNet
{
    public partial class frmBieuDoDoanhSoThang : Form
    {
        public frmBieuDoDoanhSoThang()
        {
            InitializeComponent();
        }

        private void frmBieuDoDoanhSoThang_Load(object sender, EventArgs e)
        {
         string sqlCon = @"Server=DIEUNINH\SQLEXPRESS;Database=DemoQuanLyBanHang;Integrated Security=True";

            /*  string query = @"SELECT tb_ChiTietHoaDon.IDSanPham, tb_SanPham.TenSanPham, SUM(tb_ChiTietHoaDon.SoLuong) AS SoLuongBan, SUM(TongTien) AS GiaTri FROM tb_HoaDon,tb_ChiTietHoaDon, tb_SanPham
      WHERE tb_HoaDon.IDHoaDon=tb_ChiTietHoaDon.IDHoaDon and tb_SanPham.IDSanPham=tb_ChiTietHoaDon.IDSanPham 
          AND MONTH(NgayLap) = "+ dtpThangNam.Value.Month+ " And YEAR(NgayLap)="+dtpThangNam.Value.Year+"group by tb_ChiTietHoaDon.IDSanPham,tb_SanPham.TenSanPham ORDER BY GiaTri DESC";

      */
            string query = @"SELECT  Month( NgayLap) as Thang,SUM(tb_ChiTietHoaDon.SoLuong) AS SoLuongBan
FROM tb_HoaDon,tb_ChiTietHoaDon
	WHERE tb_HoaDon.IDHoaDon=tb_ChiTietHoaDon.IDHoaDon 
		group by NgayLap";
    SqlConnection con = new SqlConnection(sqlCon);
            if (con != null)
            {
                
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                chart1.Series.Clear();
               
                chart1.DataSource = dt;
                this.chart1.Titles.Add("BIỂU ĐỒ DOANH SỐ THEO THÁNG");
                //BIỂU ĐỒ DOANH SỐ THEO THÁNG
                Series series1 =  chart1.Series.Add("Số lượng sản phẩm bán được");
                series1.XValueMember = "Thang";
                series1.YValueMembers = "SoLuongBan";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng";
             

                
            }
            else
                MessageBox.Show("Loi ket noi");


        }

        private void btnTKDoanhSo_Click(object sender, EventArgs e)
        {

        }
    }
}
