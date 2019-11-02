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
    class QuaTrinhService
    {
        public static List<QuaTrinh> getListQuaTrinh(string idSinhVien)
        {
            List<QuaTrinh> quaTrinhs = new List<QuaTrinh>();
            int t = 1;
            for(int i = 2000; i < 2020; i++)
            {
                QuaTrinh qt = new QuaTrinh
                {
                    ID = t.ToString(),
                    YearFrom = i,
                    YearTo = i + 2,
                    Address = "Hà Nội",
                    idStudent = idSinhVien
                };
                quaTrinhs.Add(qt);
                t++;
            }
            return quaTrinhs;    
        }
        public static List<QuaTrinh> getListQuaTrinh(string path,string idSinhVien)
        {
            if (File.Exists(path))
            {
                List<QuaTrinh> quaTrinhs = new List<QuaTrinh>();
                var lines = File.ReadAllLines(path);
                int t = 1;
                foreach (var l in lines)
                {
                    var quatrinh = QuaTrinh.Parse(l);
                    if (quatrinh.idStudent == idSinhVien)
                    {
                        quaTrinhs.Add(quatrinh);
                    }
                }
                return quaTrinhs;
            }
            else
            {
                return null;
            }
        }
        public static void Remove(string path,QuaTrinh quaTrinh)
        {
            if (File.Exists(path))
            {
                List<string> rs = new List<string>();
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    var data = QuaTrinh.Parse(line);
                    if (data.ID != quaTrinh.ID)
                    {
                        rs.Add(line);
                    }
                }
                File.WriteAllLines(path, rs);
            }
            else
            {
                throw new Exception("File dữ liệu không tồn tại");
            }
        }
        public static int GetIdMax(string path)
        {
            int c = 0;
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var item = QuaTrinh.Parse(line);
                if (int.Parse(item.ID) > c && item != null)
                {
                    c = int.Parse(item.ID);
                }
            }
            return c;
        }
        /// <summary>
        /// Thêm mới một quá trình học tập
        /// </summary>
        /// <param name="path">path</param>
        /// <param name="quaTrinh">Quatrinh</param>
        public static void Add(string path,QuaTrinh quaTrinh)
        {
            
            if (File.Exists(path))
            {
               
                var qt = QuaTrinh.Parse(quaTrinh);
                File.AppendAllText(path, qt);
            }
            else
            {
                throw new Exception("File dữ liệu không tồn tại");
            }

        }

        public static void Update(string path, QuaTrinh quaTrinh)
        {
            if (File.Exists(path))
            {
                List<string> rs = new List<string>();
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    var item = QuaTrinh.Parse(line);
                    if (item.ID == quaTrinh.ID)
                    {
                        rs.Add(quaTrinh.Parse());    
                    }
                    else
                    {
                        rs.Add(line);
                    }   
                }
                File.WriteAllLines(path, rs);
            }
            else
            {
                throw new Exception("File dữ liệu không tồn tại");
            }
        }
    }
}
