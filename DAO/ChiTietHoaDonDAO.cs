using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class ChiTietHoaDonDAO
    {
        SqlDataProvider db = new SqlDataProvider();


        public DataTable GetDataByID(string IDHoaDon)
        {
            SqlParameter[] param =
          {
                new SqlParameter("IDHoaDon", IDHoaDon)
            };
            return db.GetDataTable("sp_ChiTietHoaDon_Select_ByID", null);
        }
    }
}
