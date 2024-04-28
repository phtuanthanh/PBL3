using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDon
    {
        public DataTable GetHoaDon()
        {
            string query = "select * from HoaDon";
            DataTable dtHoaDon = DAL_DBHelper.Instance.GetRecords(query);
            return dtHoaDon;
        }
        public void ThemHoaDon(DTO_HoaDon a)
        {
            string query = string.Format("insert HoaDon values ('{0}', '{1}','{2}','{3}','{4}','{5},'{6}','{7}'",
              a.MaHoaDon, a.SoDienCu, a.SoDienMoi, a.SoNuocCu, a.SoNuocMoi,a.TongTien,a.MaPhongTro,a.ThoiGian);
            DAL_DBHelper.Instance.GetRecords(query);
        }

        // Sua loai phong a trong CSDL LoaiPhong
        public void CapNhatPhieuThuTien(DTO_HoaDon a)
        {
            string query = string.Format("update HoaDon set SoDienCu='{0}',SoDienMoi='{1}',SoNuocCu='{2}',SoNuocMoi='{3}',TongTien='{4}',MaPhongTro='{5}',ThoiGian='{6}'  where MaPhieuThu = {7}", a.SoDienCu, a.SoDienMoi, a.SoNuocCu, a.SoNuocMoi, a.TongTien, a.MaPhongTro, a.ThoiGian, a.MaHoaDon);
            DAL_DBHelper.Instance.GetRecords(query);
        }

        // xoa loai phong co ma loai phong a trong CSDL LoaiPhong
        public void XoaPhieuThu(string MaHoaDon)   // a : MaLoaiPhong
        {

            string query = string.Format("delete from HoaDon where MaHoaDon = '{0}'", MaHoaDon);
            DAL_DBHelper.Instance.GetRecords(query);

        }
    }
}
