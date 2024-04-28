using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        private string _MaHoaDon;
        private int _SoDienCu;
        private int _SoDienMoi;
        private int _SoNuocCu;
        private int _SoNuocMoi;
        private int _TongTien;
        private string _MaPhongTro;
        private DateTime _ThoiGian;

        public string MaHoaDon { get => _MaHoaDon; set => _MaHoaDon = value; }
        public int SoDienCu { get => _SoDienCu; set => _SoDienCu = value; }
        public int SoDienMoi { get => _SoDienMoi; set => _SoDienMoi = value; }
        public int SoNuocCu { get => _SoNuocCu; set => _SoNuocCu = value; }
        public int SoNuocMoi { get => _SoNuocMoi; set => _SoNuocMoi = value; }
        public int TongTien { get => _TongTien; set => _TongTien = value; }
        public string MaPhongTro { get => _MaPhongTro; set => _MaPhongTro = value; }
        public DateTime ThoiGian { get => _ThoiGian; set => _ThoiGian = value; }
    }
}
