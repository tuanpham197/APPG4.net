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
    public partial class frmEditContact : Form
    {
        DanhBa db;
        String idStudent;
        String idDanhBa;
        public frmEditContact(DanhBa danhBa,String idS,String id)
        {
            InitializeComponent();
            db = danhBa;
            idDanhBa = id;
            idStudent = idS;
            if (danhBa != null)
            {
                txtHoTen.Text = danhBa.Name;
                txtEmail.Text = danhBa.Email;
                txtSoDT.Text = danhBa.PhoneNumber;
                this.Text = "Cập nhật thông tin";
                btnThem.Text = "Cập nhật";
            }
            else
            {
                this.Text = "Thêm liên hệ";
                btnThem.Text = "Thêm mới";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(db != null)
            {
                DanhBa danhBa = new DanhBa
                {
                    
                    Name = txtHoTen.Text,
                    PhoneNumber = txtSoDT.Text,
                    Email = txtEmail.Text,
                    idStudent = idStudent
                };
                DanhBaService.EditContact(danhBa, idDanhBa);
                if (MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                DanhBa danhBa = new DanhBa
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = txtHoTen.Text,
                    PhoneNumber = txtSoDT.Text,
                    Email = txtEmail.Text,
                    idStudent = idStudent
                };
                DanhBaService.addContact(danhBa);
                if (MessageBox.Show("Đã Thêm thành công", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
