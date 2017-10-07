using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;

namespace BUS
{
    public class ChiTietNhapHangBUS
    {
        ChiTietNhapHangDAO dao = new ChiTietNhapHangDAO();

        public DataTable GetDataByID(string IDNhapHang)
        {
            return dao.GetDataByID(IDNhapHang);
        }
    }
}
