using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhieuThuTien
    {
        public DataTable GetPhieuThuTien()
        {
            string query = "select * from PhieuThuTien";
            DataTable dtPhieuThuTien = DAL_DBHelper.Instance.GetRecords(query);
            return dtPhieuThuTien;
        }
        public void ThemPhieuThuTien(DTO_PhieuThuTien a)
        {
            string query = string.Format("insert PhieuThuTien values ('{0}', '{1}','{2}','{3}','{4}')",
                     a.MaPhieuThu,a.MaHoaDon,a.SoTienTra,a.NgayLapPhieu,a.NoMoi);
            DAL_DBHelper.Instance.GetRecords(query);
        }

        // Sua loai phong a trong CSDL LoaiPhong
        public void CapNhatPhieuThuTien(DTO_PhieuThuTien a)
        {
            string query = string.Format("update PhieuThuTien set MaHoaDon = '{0}',SoTienTra='{1}',NgayLapPhieu='{2}',NoMoi='{3}' where MaPhieuThu = {4}",a.MaHoaDon,a.SoTienTra,a.NgayLapPhieu,a.NgayLapPhieu,a.NoMoi,a.MaPhieuThu);
            DAL_DBHelper.Instance.GetRecords(query);
        }

        // xoa loai phong co ma loai phong a trong CSDL LoaiPhong
        public void XoaPhieuThu(string MaPhieuThu)   // a : MaLoaiPhong
        {

            string query = string.Format("delete from TaiKhoan where MaPhieuThu = '{0}'", MaPhieuThu);
            DAL_DBHelper.Instance.GetRecords(query);

        }
    }
}
