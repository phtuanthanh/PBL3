using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_LoaiPhong
    {
        private static BUS_LoaiPhong _Instance;
        public static BUS_LoaiPhong Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BUS_LoaiPhong();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private BUS_LoaiPhong() { }

        // Day danh sach cac loai phong vao DataTable dtLoaiPhong 
        public DataTable getLoaiPhong()
        {
            DAL_LoaiPhong a = new DAL_LoaiPhong();
            return a.getLoaiPhong();
        }

        // Them loai phong moi a vao CSDL LoaiPhong
        public void themLoaiPhong(DTO_LoaiPhong a)
        {
            DAL_LoaiPhong dt = new DAL_LoaiPhong();
            dt.themLoaiPhong(a);
        }

        // Sua loai phong a trong CSDL LoaiPhong
        public void suaLoaiPhong(DTO_LoaiPhong a)
        {
            DAL_LoaiPhong dt = new DAL_LoaiPhong();
            dt.suaLoaiPhong(a);
        }

        // xoa loai phong co ma loai phong a trong CSDL LoaiPhong
        public void xoaLoaiPhong(int a)   // a : MaLoaiPhong
        {
            DAL_LoaiPhong dt = new DAL_LoaiPhong();
            dt.xoaLoaiPhong(a);
        }
        // tra ve ten loai phong tuong ung voi ma loai phong t trong CSDL LoaiPhong
        public string FindByMaLoaiPhong(int t)   // t : MaLoaiPhong
        {
            DAL_LoaiPhong dt = new DAL_LoaiPhong();
            return dt.FindByMaLoaiPhong(t);
        }
    }
}
