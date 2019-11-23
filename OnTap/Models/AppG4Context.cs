using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap.Models
{
    public class AppG4Context : DbContext
    {
        public AppG4Context() : base("Data Source=.;Initial Catalog=QLSinhVien;User ID=sa;Password=123")
        {

        }
        public DbSet<SinhVien> sinhViens { get; set; }
        public DbSet<QuaTrinh> quaTrinhs { get; set; }
        public DbSet<DanhBa> danhBas { get; set; }
    }
}
