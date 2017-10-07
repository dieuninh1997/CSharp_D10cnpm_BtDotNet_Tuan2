using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class ChiTietNhapHangDAO
    {
        SqlDataProvider db = new SqlDataProvider();


        public DataTable GetDataByID(string IDNhapHang)
        {
            SqlParameter[] param =
          {
                new SqlParameter("IDNhapHang", IDNhapHang)
            };
            return db.GetDataTable("sp_ChiTietNhapHang_Select_ByID", null);
        }
    }
}
