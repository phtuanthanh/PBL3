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
    public class BUS_TTLT
    {
        private static BUS_TTLT _Instance;
        public static BUS_TTLT Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BUS_TTLT();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private BUS_TTLT() { }
        public int GetTienNuoc(string MaTTLT)
        {
            int tiennuoc = 0;
            DAL_TTLT a = new DAL_TTLT();
            tiennuoc = a.GetTienNuoc(MaTTLT);
            return tiennuoc;
        }
        public int GetTienDien(string MaTTLT)
        {
            int tiendien = 0;
            DAL_TTLT a = new DAL_TTLT();
            tiendien = a.GetTienDien(MaTTLT);
            return tiendien;
        }
        public int GetTienNo(string MaTTLT)
        {
            int tienno = 0;
            DAL_TTLT a = new DAL_TTLT();
            tienno = a.GetTienNo(MaTTLT);
            return tienno;
        }
        public DataTable GetTTLT()
        {
            DAL_TTLT a = new DAL_TTLT();
            return a.GetTTLT();
        }
        public void ThemTTLT(DTO_TTLT ttlt)
        {
            DAL_TTLT a = new DAL_TTLT();
            a.ThemTTLT(ttlt);
        }
        public void CapNhatTTLT(DTO_TTLT ttlt)
        {
            DAL_TTLT a = new DAL_TTLT();
            a.CapNhatTTLT(ttlt);
        }
        public void XoaTTLT(string TTLT)
        {
            DAL_TTLT a = new DAL_TTLT();
            a.XoaTTLT(TTLT);
        }
    }
}
