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
    public class BUS_TaiKhoan
    {
        private static BUS_TaiKhoan _Instance;
        public static BUS_TaiKhoan Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BUS_TaiKhoan();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private BUS_TaiKhoan() { }

        // Day danh sach cac loai phong vao DataTable dtLoaiPhong 
        public int GetMaTaiKhoan(string UserName, string Password)
        {
            DAL_TaiKhoan a = new DAL_TaiKhoan();
            return a.GetMaTaiKhoan(UserName,Password);
        }
        public DataTable GetTaiKhoan()
        {
            DAL_TaiKhoan a = new DAL_TaiKhoan();
            return a.GetTaiKhoan();
        }
        public void ThemTaiKhoan(DTO_TaiKhoan taikhoan)
        {
            DAL_TaiKhoan a = new DAL_TaiKhoan();
            a.ThemTaiKhoan(taikhoan);
        }
        public void CapNhatMatKhau(string NewPassWord, int ID)
        {
            DAL_TaiKhoan a = new DAL_TaiKhoan();
            a.CapNhatMatKhau(NewPassWord,ID);
        }
        public void XoaTaiKhoan(int ID)   // a : MaLoaiPhong
        {
            DAL_TaiKhoan a = new DAL_TaiKhoan();
            a.XoaTaiKhoan(ID);
        }
        public int PhanQuyenTaiKhoan(string UserName, string PassWord)
        {
            DAL_TaiKhoan a = new DAL_TaiKhoan();
            return a.PhanQuyenTaiKhoan(UserName,PassWord);
        }
    }

}

