using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap.Models
{
    public class QuaTrinh
    {
        [Key]
        public string ID { get; set; }
        public int YearFrom { get; set; }
        public int YearTo { get; set; }
        public string Address { get; set; }
        
        public string idStudent { get; set; }
        [ForeignKey("idStudent")]
        public virtual SinhVien sinhVien { get; set; }

        /// <summary>
        /// chuyển đổi một chuỗi thành đối tuownjgg\
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static QuaTrinh Parse(string data)
        {
            var item = data.Split(new char[] { '#' });
            QuaTrinh qt = new QuaTrinh
            {
                ID = item[0],
                YearFrom = int.Parse(item[1]),
                YearTo = int.Parse(item[2]),
                Address = item[3],
                idStudent = item[4]
            };
            return qt;
        }
        /// <summary>
        /// chuyển đổi một đối tượng thành chuỗi
        /// </summary>
        /// <param name="qt"></param>
        /// <returns></returns>
        public static string Parse(QuaTrinh qt)
        {
            return  string.Format("{0}#{1}#{2}#{3}#{4}\n", qt.ID, qt.YearFrom, qt.YearTo, qt.Address, qt.idStudent);
        }

        public string Parse()
        {
            return string.Format("{0}#{1}#{2}#{3}#{4}", this.ID, this.YearFrom, this.YearTo, this.Address, this.idStudent);
        }
    }
}
