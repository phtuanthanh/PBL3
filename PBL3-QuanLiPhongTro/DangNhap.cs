using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLiPhongTro
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            int Role = BUS_TaiKhoan.Instance.PhanQuyenTaiKhoan(txtUserName.Text,txtPassWord.Text);
            if (Role == 0)
            {
                Admin form1 = new Admin();
                form1.ShowDialog();
            }
            else
            {
                KhachHang form2 = new KhachHang();
                form2.ShowDialog();
            }

        }
    }
}
