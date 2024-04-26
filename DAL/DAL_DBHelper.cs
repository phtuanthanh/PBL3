using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{

    public class DAL_DBHelper
    {
        private SqlConnection _conn;
        private static DAL_DBHelper _Instance;

        public static DAL_DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string s = "";
                    _Instance = new DAL_DBHelper(s);
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_DBHelper(string s) {
        _conn = new SqlConnection(s);
        }
        public DataTable GetRecords(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            _conn.Open();
            adapter.Fill(dt);
            _conn.Close();
            return dt;
        }
        public void ExecuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, _conn);
            _conn.Open();
            cmd.CommandText = query;
            _conn.Close();
        }
    }
}
