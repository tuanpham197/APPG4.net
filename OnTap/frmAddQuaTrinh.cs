using OnTap.Models;
using OnTap.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap
{
    public partial class frmAddQuaTrinh : Form
    {
        string pathQuaTrinh;
        string idSinhVien;
        QuaTrinh quaTrinhHocTap;
        public frmAddQuaTrinh(QuaTrinh quaTrinh,string idSv)
        {
            InitializeComponent();
            pathQuaTrinh = Application.StartupPath + @"\Data\quatrinh.txt";
            idSinhVien = idSv;
            quaTrinhHocTap = quaTrinh;
            if(quaTrinh != null)
            {
                this.Text = "Cập nhật thông tin";
                btnThem.Text = "Cập nhật";
                nudFromYear.Value = quaTrinh.YearFrom;
                nudToYear.Value = quaTrinh.YearTo;
                txtAddress.Text = quaTrinh.Address;
            }else
            {
                this.Text = "Thêm quá trình học tập";
                btnThem.Text = "Thêm";
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(quaTrinhHocTap != null)
            {
                // xử lý sửa thông tin
                int from = int.Parse(nudFromYear.Value.ToString());
                int to = int.Parse(nudToYear.Value.ToString());
                string school = txtAddress.Text;
                QuaTrinh quaTrinh = new QuaTrinh
                {
                    ID = quaTrinhHocTap.ID,
                    YearFrom = from,
                    YearTo = to,
                    Address = school,
                    idStudent = idSinhVien
                };
                QuaTrinhService.Update(pathQuaTrinh, quaTrinh);
                if (MessageBox.Show("Đã Sửa thành công", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                // xử lý thêm mới
                int from = int.Parse(nudFromYear.Value.ToString());
                int to = int.Parse(nudToYear.Value.ToString());
                string school = txtAddress.Text;
                /*
                 Guid.NewGuid().ToString()
                 tạo id với 32 kí tự
                 */

                int id = QuaTrinhService.GetIdMax(pathQuaTrinh);
                QuaTrinh quaTrinh = new QuaTrinh
                {
                    ID = (id + 1).ToString(),
                    YearFrom = from,
                    YearTo = to,
                    Address = school,
                    idStudent = idSinhVien
                };
                QuaTrinhService.Add(pathQuaTrinh, quaTrinh);
                if (MessageBox.Show("Đã Thêm thành công", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
