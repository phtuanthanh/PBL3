using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HopDong
    {
        private int _MaHopDong;
        private int _MaKhachTro;
        private int _MaPhongTro;
        private DateTime _NgayThue;
        private int _TienCoc;

        public int MaHopDong { get => _MaHopDong; set => _MaHopDong = value; }
        public int MaKhachTro { get => _MaKhachTro; set => _MaKhachTro = value; }
        public int MaPhongTro { get => _MaPhongTro; set => _MaPhongTro = value; }
        public DateTime NgayThue { get => _NgayThue; set => _NgayThue = value; }
        public int TienCoc { get => _TienCoc; set => _TienCoc = value; }
    }
}
