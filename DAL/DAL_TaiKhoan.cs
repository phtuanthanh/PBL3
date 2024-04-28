using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class DAL_TaiKhoan
    {
        public int GetMaTaiKhoan(string UserName, string PassWord)
        {
            int ID =0;
            string query = string.Format("select * from TaiKhoan where UserName = '{0}' and PassWord ='{1}')",
                  UserName, PassWord);
            DataTable dt = DAL_DBHelper.Instance.GetRecords(query);
            foreach (DataRow row in dt.Rows)
            {
                ID = Convert.ToInt32(row["ID"]);
            }
            return ID;  
        }
        public DataTable GetTaiKhoan()
        {
            string query = "select * from TaiKhoan";
            DataTable dtTaiKhoan = DAL_DBHelper.Instance.GetRecords(query);
            return dtTaiKhoan;
        }
        public void ThemTaiKhoan(DTO_TaiKhoan a)
        {
            string query = string.Format("insert TaiKhoan values ('{0}', '{1}','{2}')",
                     a.UserName, a.PassWord,a.Role);
            DAL_DBHelper.Instance.GetRecords(query);
        }

        // Sua loai phong a trong CSDL LoaiPhong
        public void CapNhatMatKhau(string NewPassWord, int ID)
        {
            string query = string.Format("update TaiKhoan set PassWord = '{0}' where ID = {1}", NewPassWord, ID);
            DAL_DBHelper.Instance.GetRecords(query);
        }

        // xoa loai phong co ma loai phong a trong CSDL LoaiPhong
        public void XoaTaiKhoan(int ID)   // a : MaLoaiPhong
        {

            string query = string.Format("delete from TaiKhoan where ID = '{0}'", ID);
            DAL_DBHelper.Instance.GetRecords(query);

        }
        // tra ve ten loai phong tuong ung voi ma loai phong t trong CSDL LoaiPhong
        public bool TonTaiTaiKhoan(DTO_TaiKhoan a)   // t : MaLoaiPhong
        {
            string query = "select * from TaiKhoan";
            DataTable dt = DAL_DBHelper.Instance.GetRecords(query);
            foreach (DataRow row in dt.Rows)
            {
                if ( Convert.ToInt32(row["ID"]) == a.MaTaiKhoan|| row["PassWord"] == a.PassWord || row["UserName"] == a.UserName)
                {
                    return false;
                }
            }
            return true;
        }
        public int PhanQuyenTaiKhoan(string UserName,string PassWord)
        {
            int Role = -1;
            string query = string.Format("select * from TaiKhoan where UserName = '{0}' and PassWord ='{1}'",
                  UserName,PassWord);
            DataTable dt = DAL_DBHelper.Instance.GetRecords(query);
            foreach (DataRow row in dt.Rows)
            {
                Role = Convert.ToInt32(row["Role"]);
            }
            return Role;
        }
    }

    }
