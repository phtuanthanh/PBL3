using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class DAL_TTLT
    {
        public int GetTienNuoc(string MaTTLT)
        {
            int tiennuoc = 0;
            string query = string.Format("select * from TTLT where MaTTLT='{0}'", MaTTLT);
            DataTable dt = DAL_DBHelper.Instance.GetRecords(query);
            foreach (DataRow row in dt.Rows)
            {
                tiennuoc = Convert.ToInt32(row["SoNuoc"].ToString());
            }
            return tiennuoc;
        }
        public int GetTienDien(string MaTTLT)
        {
            int tiendien = 0;
            string query = string.Format("select * from TTLT where MaTTLT='{0}'", MaTTLT);
            DataTable dt = DAL_DBHelper.Instance.GetRecords(query);
            foreach (DataRow row in dt.Rows)
            {
                tiendien = Convert.ToInt32(row["SoDien"].ToString());
            }
            return tiendien;
        }
        public int GetTienNo(string MaTTLT)
        {
            int tienno = 0;
            string query = string.Format("select * from TTLT where MaTTLT='{0}'", MaTTLT);
            DataTable dt = DAL_DBHelper.Instance.GetRecords(query);
            foreach (DataRow row in dt.Rows)
            {
                tienno = Convert.ToInt32(row["SoTienNo"].ToString());
            }
            return tienno;
        }
        public DataTable GetTTLT()
        {
            string query = "select * from TTLT";
            DataTable dtTTLT = DAL_DBHelper.Instance.GetRecords(query);
            return dtTTLT;
        }
        public void ThemTTLT(DTO_TTLT a)
        {
            string query = string.Format("insert TTLT values ('{0}', '{1}','{2}')",
                     a.SoDien, a.SoNuoc, a.SoTienNo);
            DAL_DBHelper.Instance.GetRecords(query);
        }

        // Sua loai phong a trong CSDL LoaiPhong
        public void CapNhatTTLT(DTO_TTLT a)
        {
            string query = string.Format("update TaiKhoan set SoDien = '{0}',SoNuoc='{1}',SoTienNo='{2}' where MaTTLT = {3}", a.SoDien, a.SoNuoc, a.SoTienNo, a.MaTTLT);
            DAL_DBHelper.Instance.GetRecords(query);
        }
        // xoa loai phong co ma loai phong a trong CSDL LoaiPhong
        public void XoaTTLT(string TTLT)   // a : MaLoaiPhong
        {
            string query = string.Format("delete from TTLT where TTLT = '{0}'", TTLT);
            DAL_DBHelper.Instance.GetRecords(query);
        }
    }
}