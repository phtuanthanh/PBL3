using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HopDong
    {
        private static DAL_HopDong _Instance;
        public static DAL_HopDong Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_HopDong();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }
        public DataTable Get()
        {
            string query = "select * from HopDong";
            DataTable dt = DataProvider.Instance.GetRecords(query);
            return dt;
        }
        
        // them hop dong a vao CSDL HopDong
        public void Them(DTO_HopDong a)
        {
            string query = string.Format("insert HopDong values ('{0}', '{1}', '{2}', '{3}', '{4}'",
              a.MaHopDong, a.MaKhachTro, a.MaPhongTro, a.NgayThue.ToString("yyyy-MM-dd HH:mm:ss"), a.TienCoc);
            DataProvider.Instance.GetRecords(query);
        }

        // Sua loai hop dong a trong CSDL HopDong
        public void Sua(DTO_HopDong a)
        {
            string query = string.Format("update HopDong set MaKhachTro = '{0}', MaPhongTro = '{1}', NgayThue = '{2}', TienCoc = '{3}' where MaHopDong = {4}", 
                a.MaKhachTro, a.MaPhongTro, a.NgayThue.ToString("yyyy-MM-dd HH:mm:ss"), a.TienCoc, a.MaHopDong);
            DataProvider.Instance.GetRecords(query);
        }

        // xoa hop dong trong CSDL HopDong
        public void Xoa(int a)   // a : MaLoaiPhong
        {
            string query = string.Format("delete from HopDong where MaHopDong = '{0}'", a);
            DataProvider.Instance.GetRecords(query);
        }

    }
}
