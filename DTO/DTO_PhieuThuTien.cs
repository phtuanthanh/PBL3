using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuThuTien
    {
        private string _MaPhieuThu;
        private string _MaHoaDon;
        private int _SoTienTra;
        private DateTime _NgayLapPhieu;
        private int _NoMoi;

        public string MaPhieuThu { get => _MaPhieuThu; set => _MaPhieuThu = value; }
        public string MaHoaDon { get => _MaHoaDon; set => _MaHoaDon = value; }
        public int SoTienTra { get => _SoTienTra; set => _SoTienTra = value; }
        public DateTime NgayLapPhieu { get => _NgayLapPhieu; set => _NgayLapPhieu = value; }
        public int NoMoi { get => _NoMoi; set => _NoMoi = value; }
    }
}
