using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap.Models
{
    public class DanhBa
    {
        [Key]
        public String ID { get; set; }
        public String Name { get; set; }
        public String PhoneNumber { get; set; }
        public String Email { get; set; }
        public string idStudent { get; set; }
        [ForeignKey("idStudent")]
        public virtual SinhVien sinhVien { get; set; }

    }
}
