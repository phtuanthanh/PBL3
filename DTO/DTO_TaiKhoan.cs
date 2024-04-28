using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        private int _Role;
        private int _MaTaiKhoan;
        private string _UserName;
        private string _PassWord;

       
        public string UserName { get => _UserName; set => _UserName = value; }
        public string PassWord { get => _PassWord; set => _PassWord = value; }
        public int Role { get => _Role; set => _Role = value; }
        public int MaTaiKhoan { get => _MaTaiKhoan; set => _MaTaiKhoan = value; }
    }
}
