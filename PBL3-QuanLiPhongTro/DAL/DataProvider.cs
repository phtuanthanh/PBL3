using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataProvider
    {
        private string cnnstring;
        private static DataProvider _instance;
        public static DataProvider instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataProvider();
                return _instance;
            }
            private set { _instance = value; }
        }

        private DataProvider()
        {
            cnnstring = @"Data Source=DESKTOP-SCUSLUI;Initial Catalog=QLSV;Integrated Security=True";     // connect link
        }

        public bool ExecuteDB(string query)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(cnnstring))
                {
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DataTable GetRecord(string query)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection cnn = new SqlConnection(cnnstring))
                {
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cnn.Open();
                    da.Fill(dt);
                    cnn.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
