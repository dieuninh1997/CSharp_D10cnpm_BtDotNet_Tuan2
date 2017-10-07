using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;

namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        ChiTietHoaDonDAO dao = new ChiTietHoaDonDAO();

        public DataTable GetDataByID(string IDHoaDon)
        {
            return dao.GetDataByID(IDHoaDon);
        }
    }
}
