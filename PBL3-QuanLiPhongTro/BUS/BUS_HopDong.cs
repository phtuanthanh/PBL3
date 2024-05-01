using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_HopDong
    {
        private static BUS_HopDong _Instance;
        public static BUS_HopDong Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BUS_HopDong();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }
        // get
        public DataTable Get()
        {
            return DAL_HopDong.Instance.Get();
        }

        // them
        public void Them(DTO_HopDong a)
        {
            DAL_HopDong.Instance.Them(a);
        }

        // sua
        public void Sua(DTO_HopDong a)
        {
            DAL_HopDong.Instance.Sua(a);
        }

        // xoa
        public void Xoa(int a)   // a : MaLoaiPhong
        {
            DAL_HopDong.Instance.Xoa(a);
        }
    }
}
