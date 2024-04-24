using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_LoaiPhong : DBQuanLy
    {
        private static DAL_LoaiPhong _Instance;
        public static DAL_LoaiPhong Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_LoaiPhong();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private DAL_LoaiPhong() { }
        
        // Day danh sach cac loai phong vao DataTable dtLoaiPhong 
        public DataTable getLoaiPhong()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from LoaiPhong", _conn);
            DataTable dtLoaiPhong = new DataTable();
            da.Fill(dtLoaiPhong);
            return dtLoaiPhong;
        }

        // Them loai phong moi a vao CSDL LoaiPhong
        public bool themLoaiPhong(DTO_LoaiPhong a)
        {
            try
            {
                _conn.Open();
                string sql = string.Format("insert LoaiPhong values ('{0}', '{1}', '{2}', '{3}')",
                    a.TenLoaiPhong, a.DienTichPhong, a.DonGia, a.GhiChu);
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception");
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        // Sua loai phong a trong CSDL LoaiPhong
        public bool suaLoaiPhong(DTO_LoaiPhong a)
        {
            try
            {
                _conn.Open();
                string sql = string.Format("update LoaiPhong set TenLoaiPhong = '{0}', DienTichPhong = {1}, DonGia = {2}, GhiChu = '{3}' where MaLoaiPhong = {4}",
                    a.TenLoaiPhong, a.DienTichPhong, a.DonGia, a.GhiChu, a.MaLoaiPhong);
                SqlCommand cmd = new SqlCommand(sql, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        // xoa loai phong co ma loai phong a trong CSDL LoaiPhong
        public bool xoaLoaiPhong(int a)   // a : MaLoaiPhong
        {
            try
            {
                _conn.Open();
                string sql = string.Format("delete from LoaiPhong where MaLoaiPhong = {0}", a);
                SqlCommand cmd = new SqlCommand(sql, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        // tra ve ten loai phong tuong ung voi ma loai phong t trong CSDL LoaiPhong
        public string FindByMaLoaiPhong(int t)   // t : MaLoaiPhong
        {
            try
            {
                _conn.Open();
                string sql = string.Format("select * from LoaiPhong where MaLoaiPhong = '{0}'", t);
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    return r["TenLoaiPhong"].ToString();
                }
                return "";
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return "";
        }
    }
}
