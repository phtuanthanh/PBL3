using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TTLT
    {
        private string _MaTTLT;
        private int _SoDien;
        private int _SoNuoc;
        private int _SoTienNo;

        public string MaTTLT { get => _MaTTLT; set => _MaTTLT = value; }
        public int SoDien { get => _SoDien; set => _SoDien = value; }
        public int SoNuoc { get => _SoNuoc; set => _SoNuoc = value; }
        public int SoTienNo { get => _SoTienNo; set => _SoTienNo = value; }
    }
}
