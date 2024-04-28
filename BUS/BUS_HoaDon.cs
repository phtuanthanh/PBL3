using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HoaDon
    {

        private static BUS_HoaDon _Instance;
        public static BUS_HoaDon Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BUS_HoaDon();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private BUS_HoaDon() { }
        public DataTable GetHoaDon()
        {
            DAL_HoaDon a = new DAL_HoaDon();
            return a.GetHoaDon();
        }
        public void ThemHoaDon(DTO_HoaDon hoadon)
        {
            DAL_HoaDon a = new DAL_HoaDon();
            a.ThemHoaDon(hoadon);
        }
        public void CapNhatPhieuThuTien(DTO_HoaDon hoadon)
        {
            DAL_HoaDon a = new DAL_HoaDon();
            a.CapNhatPhieuThuTien(hoadon);
        }
        public void XoaPhieuThu(string MaHoaDon)   // a : MaLoaiPhong
        {
            DAL_HoaDon a = new DAL_HoaDon();
            a.XoaPhieuThu(MaHoaDon);
        }

    }
}
