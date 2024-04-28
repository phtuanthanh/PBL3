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
    public class BUS_PhieuThuTien
    {
        private static BUS_PhieuThuTien _Instance;
        public static BUS_PhieuThuTien Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BUS_PhieuThuTien();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private BUS_PhieuThuTien() { }
        public DataTable GetPhieuThuTien()
        {
            DAL_PhieuThuTien a = new DAL_PhieuThuTien();
            return a.GetPhieuThuTien();
        }
        public void ThemPhieuThuTien(DTO_PhieuThuTien phieuthutien)
        {
            DAL_PhieuThuTien a = new DAL_PhieuThuTien();
            a.ThemPhieuThuTien(phieuthutien);
        }
        public void CapNhatPhieuThuTien(DTO_PhieuThuTien phieuthutien)
        {
            DAL_PhieuThuTien a = new DAL_PhieuThuTien();
            a.CapNhatPhieuThuTien(phieuthutien);
        }
        public void XoaPhieuThu(string MaPhieuThu)
        {
            DAL_PhieuThuTien a = new DAL_PhieuThuTien();
            a.XoaPhieuThu(MaPhieuThu);
        }
    }

    }
