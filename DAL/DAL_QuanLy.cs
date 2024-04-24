using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DBQuanLy
    {
        protected SqlConnection _conn = new SqlConnection("Source here");
    }
}
