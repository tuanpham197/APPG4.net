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
    public partial class Form1 : Form
    {
        string anhDaiDienPathDirectory;
        string anhDaiDienPathFile;
        string pathSinhVien;
        string pathQuaTrinh;
        public Form1(string idSinhVien)
        {
            InitializeComponent();
            anhDaiDienPathDirectory = Application.StartupPath + @"\AnhDaiDien";
            anhDaiDienPathFile = anhDaiDienPathDirectory + @"\avatar.jpg";
            pathSinhVien = Application.StartupPath + @"\Data\sinhvien.txt";
            pathQuaTrinh = Application.StartupPath + @"\Data\quatrinh.txt";
            if (File.Exists(anhDaiDienPathFile))
            {
                FileStream file = new FileStream(anhDaiDienPathFile, FileMode.Open, FileAccess.Read);
                ptbAvatar.Image = Image.FromStream(file);
                file.Close();
            }

            //List<QuaTrinh> quaTrinhs = QuaTrinhService.getListQuaTrinh(idSinhVien);
            //SinhVien sinhVien = StudentService.getSinhVien("15t1021201");
            SinhVien sinhVien = StudentService.getSinhVienToFile(pathSinhVien, "101");
        
            txtMa.Text = sinhVien.ID;
            txtTen.Text = sinhVien.FullName;
            dtpNgaySinh.Value = sinhVien.DateOfBirth;
            ckbGioiTinh.Checked = sinhVien.Gender == Models.GENDER.Male;
            txtNoiSinh.Text = sinhVien.PlaceOfBirth;

            //sinhVien.quaTrinh = QuaTrinhService.getListQuaTrinh("102");
            sinhVien.quaTrinh = QuaTrinhService.getListQuaTrinh(pathQuaTrinh, sinhVien.ID);
            dgvQuaTrinh.AutoGenerateColumns = false;
            bdsQuaTrinh.DataSource = sinhVien.quaTrinh;

            dgvQuaTrinh.DataSource = bdsQuaTrinh;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void lnkSelectImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File ảnh(*.jpg, *.png)|*.png;*.jpg";
            openFileDialog.Title = "Chọn ảnh đại diện";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy path file image 
                var fileName = openFileDialog.FileName;
                // get file ảnh từ đường dẫn
                FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                var anhDaiDien = Image.FromStream(fileStream);
                //Lưu ảnh vào forlder của project
                if (!Directory.Exists(anhDaiDienPathDirectory))
                {
                    Directory.CreateDirectory(anhDaiDienPathDirectory);
                }
                anhDaiDien.Save(anhDaiDienPathFile);
                // set ảnh cho pictureBox 
                ptbAvatar.Image = anhDaiDien;
                fileStream.Close();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmAddQuaTrinh f = new frmAddQuaTrinh();
            f.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có muốn xóa không",
                                        "Thông báo",
                                        MessageBoxButtons.OKCancel,
                                        MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                

                MessageBox.Show("Đã xóa thành công", "Thông báo");
            }
        }
    }
}
