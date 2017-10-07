using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class NhapHangDAO
    {
        SqlDataProvider db = new SqlDataProvider();


        public DataTable GetData()
        {
            return db.GetDataTable("sp_NhapHang_Select_All", null);
        }
    }
}
