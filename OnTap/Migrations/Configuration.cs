namespace OnTap.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OnTap.Models.AppG4Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OnTap.Models.AppG4Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.sinhViens.AddOrUpdate(new Models.SinhVien
            {
                ID = "101",
                FirstName = "Tuan",
                LastName = "Phamm",
                DateOfBirth = new DateTime(2000, 2, 3),
                Gender = Models.GENDER.Male,
                PlaceOfBirth = "Hue"
            },
            new Models.SinhVien
            {
                ID = "102",
                FirstName = "Tuan",
                LastName = "Anh",
                DateOfBirth = new DateTime(2000, 2, 3),
                Gender = Models.GENDER.Male,
                PlaceOfBirth = "Da Nang"
            });
            context.SaveChanges();
            int t = 1;
            for (int i = 2000; i < 2010; i++)
            {
                context.quaTrinhs.AddOrUpdate(new Models.QuaTrinh
                {
                    ID = t.ToString(),
                    YearTo = i,
                    YearFrom = i+1,
                    Address = "Huế",
                    idStudent = "101",
                });
                t++;
                
            }
            context.SaveChanges();
            for (int i = 1; i < 10; i++)
            {
                context.danhBas.AddOrUpdate(new Models.DanhBa
                {
                    ID = i.ToString(),
                    Name = "A Minh",
                    PhoneNumber = "01242892122",
                    Email = "minh@gmail.com",
                    idStudent = "101"
                });  

            };

        }
    }
}
