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
    public partial class frmDanhBa : Form
    {
        SinhVien sv;
        String idSV;
        public frmDanhBa(String IDsinhVien)
        {
            InitializeComponent();
            sv = StudentService.GetSinhVienFromDB(IDsinhVien);
            idSV = IDsinhVien;
            dgvContact.AutoGenerateColumns = false;

            bdsContact.DataSource = sv.danhBas;
            dgvContact.DataSource = bdsContact;
            addItemFlowLayout();


        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            bdsContact.DataSource = DanhBaService.FilterContactByCharFirst(clickedButton.Text, idSV);
        }
        private void addItemFlowLayout()
        {
            
            foreach(DanhBa d in sv.danhBas)
            {
                Button b = new Button { Width = 30 };
                b.Click += btnNew_Click;
                b.Tag = d.Name[0].ToString().ToUpper();
                b.Text = d.Name[0].ToString().ToUpper();
                fllKey.Controls.Add(b);
            }
        }

        public void loadData()
        {
            sv = StudentService.GetSinhVienFromDB(idSV);
            bdsContact.DataSource = sv.danhBas;
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            bdsContact.DataSource = DanhBaService.SearchContact(txtSearch.Text, idSV);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEditContact frmEdit = new frmEditContact(null,sv.ID,null);
            frmEdit.ShowDialog();
            loadData();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var rs = MessageBox.Show("Bạn có muốn xóa không",
                                       "Thông báo",
                                       MessageBoxButtons.OKCancel,
                                       MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                DanhBa db = bdsContact.Current as DanhBa;
                DanhBaService.deleteContact(db.ID);
                bdsContact.RemoveCurrent();
                bdsContact.ResetBindings(true);
            }
            


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DanhBa d =  bdsContact.Current as DanhBa;
            frmEditContact frmEdit = new frmEditContact(d,null,d.ID);
            frmEdit.ShowDialog();
            loadData();
        }

        private void fllKey_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(this.Text)
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false };
                if(ofd.ShowDialog()  == DialogResult.OK)
                {
                    MessageBox.Show(ofd.FileName);
                    String path = ofd.FileName;
                    StreamReader sr = new StreamReader(ofd.FileName);
                    while (sr.ReadLine()!=null)
                    {


                        String line = sr.ReadLine();
                        String[] arr = line.Split(',');
                        DanhBa danhBa = new DanhBa()
                        {
                            ID = arr[0],
                            Name = arr[1],
                            PhoneNumber = arr[2],
                            Email = arr[3],
                            idStudent = arr[4]
                        };
                        MessageBox.Show(danhBa.Name);
                        DanhBaService.addContact(danhBa);
                    }
                }
            }
            catch
            {

            }
        }
    }
}
