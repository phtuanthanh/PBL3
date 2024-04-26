using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DAL_KhachTro
    {
        public DataTable getLoaiPhong()
        {
            string query = "select * from KhachTro";
            DataTable dtLoaiPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtLoaiPhong;
        }

    }
}
