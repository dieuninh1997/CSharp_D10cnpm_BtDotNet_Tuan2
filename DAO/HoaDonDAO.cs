using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace DAO
{
    public class HoaDonDAO
    {
        SqlDataProvider db = new SqlDataProvider();


        public DataTable GetData()
        {
            
            return db.GetDataTable("sp_HoaDon_Select_All", null);
        }


    }
}
