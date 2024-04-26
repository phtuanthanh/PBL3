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
    public class DAL_LoaiPhong
    {
       // Day danh sach cac loai phong vao DataTable dtLoaiPhong 
        public DataTable getLoaiPhong()
        {
            string query = "select * from LoaiPhong";
            DataTable dtLoaiPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtLoaiPhong;
        }

        // Them loai phong moi a vao CSDL LoaiPhong
        public void themLoaiPhong(DTO_LoaiPhong a)
        {
           string query = string.Format("insert LoaiPhong values ('{0}', '{1}', '{2}', '{3}')",
                    a.TenLoaiPhong, a.DienTichPhong, a.DonGia, a.GhiChu);
                DAL_DBHelper.Instance.GetRecords(query);          
        }

        // Sua loai phong a trong CSDL LoaiPhong
        public void suaLoaiPhong(DTO_LoaiPhong a)
        {
            try
            {
                string query = string.Format("update LoaiPhong set TenLoaiPhong = '{0}', DienTichPhong = {1}, DonGia = {2}, GhiChu = '{3}' where MaLoaiPhong = {4}",a.TenLoaiPhong, a.DienTichPhong, a.DonGia, a.GhiChu, a.MaLoaiPhong);
                DAL_DBHelper.Instance.GetRecords(query);
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
        }

        // xoa loai phong co ma loai phong a trong CSDL LoaiPhong
        public void xoaLoaiPhong(int a)   // a : MaLoaiPhong
        {
            try
            {
                string query = string.Format("delete from LoaiPhong where MaLoaiPhong = {0}", a);
                DAL_DBHelper.Instance.GetRecords(query);
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
        }
        // tra ve ten loai phong tuong ung voi ma loai phong t trong CSDL LoaiPhong
        public string FindByMaLoaiPhong(int t)   // t : MaLoaiPhong
        {
            try
            {
                string query = string.Format("select * from LoaiPhong where MaLoaiPhong = '{0}'", t);
                DataTable r = DAL_DBHelper.Instance.GetRecords(query);

                foreach(DataRow dr in r.Rows) {
                    return dr["Tenloaiphong"].ToString();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return "";
        }
    }
}
