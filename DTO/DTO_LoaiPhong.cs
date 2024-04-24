using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiPhong
    {
        private int _MaLoaiPhong;
        public int MaLoaiPhong
        {
            get { return _MaLoaiPhong; }
            set { _MaLoaiPhong = value; }
        }
        private string _TenLoaiPhong;
        public string TenLoaiPhong
        {
            get { return _TenLoaiPhong; }
            set { _TenLoaiPhong = value; }
        }
        private int _DienTichPhong;
        public int DienTichPhong
        {
            get { return _DienTichPhong; }
            set { _DienTichPhong = value; }
        }
        private int _DonGia;
        public int DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }
        private string _GhiChu;
        public string GhiChu
        {
            set { _GhiChu = value; }
            get { return _GhiChu; }
        }
    }
}
