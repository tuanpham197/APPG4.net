using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnTap.Models;

namespace OnTap.Service
{
    class StudentService
    {
        /// <summary>
        /// get sinh vien by idsinhvien
        /// </summary>
        /// <param name="idSinhVien"></param>
        /// <returns>sinhvien</returns>
        public static SinhVien getSinhVien(string idSinhVien)
        {
            SinhVien sv = new SinhVien
            {
                ID = idSinhVien,
                FirstName = "Pham",
                LastName = "Tuan",
                DateOfBirth = new DateTime(1997, 7, 20),
                Gender = (int)GENDER.Male,
                PlaceOfBirth = "Nghe An"
            };
            return sv;
        }

        public static SinhVien getSinhVienToFile(string path,string idStudent)
        {
            var lines = File.ReadAllLines(path);
            foreach(var l in lines)
            {
                var item = l.Split(new char[] { '#'});
                SinhVien sv = new SinhVien
                {
                    ID = item[0],
                    FirstName = item[1],
                    LastName = item[2],

                    DateOfBirth = DateTime.ParseExact(item[3], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    PlaceOfBirth = item[4],
                    Gender = item[5] == "Male" ? GENDER.Male : (item[5] == "Female" ? GENDER.Female : GENDER.Orther)
                };

                if(sv.ID == idStudent)
                {
                    return sv;
                }
            }
            return null;
        }

        public static SinhVien GetSinhVienFromDB(string idstudent)
        {
            return new AppG4Context().sinhViens.Where(e => e.ID == idstudent).FirstOrDefault();
        }
    }
}
