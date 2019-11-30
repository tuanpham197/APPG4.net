using OnTap.Models;
using OnTap.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SinhVien sv = StudentService.CheckLoginUser(txtTenDangNhap.Text, txtMatKhau.Text);
            if (sv != null)
            {
                frmDanhBa frm = new frmDanhBa(sv.ID);
                frm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Thông tin tài khoản or mật khẩu không chính xác");
            }
        }
    }
}
