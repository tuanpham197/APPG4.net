using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap.Models
{
    public class SinhVien
    {
        [Key]
        public String ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GENDER Gender { get; set; }
        public String PlaceOfBirth { get; set; }

        public virtual ICollection<QuaTrinh> quaTrinh { get; set; }

        public String FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
    }
    public enum GENDER
    {
        Male,Female,Orther
    }
}
