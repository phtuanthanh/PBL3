using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
    }
}
