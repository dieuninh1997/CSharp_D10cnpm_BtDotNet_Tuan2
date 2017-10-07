using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;

namespace BUS
{
 public   class NhapHangBUS
    {
        NhapHangDAO dao = new NhapHangDAO();
        public DataTable GetData()
        {
            return dao.GetData();
        }
    }
}
