namespace OnTap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class khoitaodb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuaTrinhs",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        YearFrom = c.Int(nullable: false),
                        YearTo = c.Int(nullable: false),
                        Address = c.String(),
                        idStudent = c.String(),
                        sinhVien_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SinhViens", t => t.sinhVien_ID)
                .Index(t => t.sinhVien_ID);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.Int(nullable: false),
                        PlaceOfBirth = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuaTrinhs", "sinhVien_ID", "dbo.SinhViens");
            DropIndex("dbo.QuaTrinhs", new[] { "sinhVien_ID" });
            DropTable("dbo.SinhViens");
            DropTable("dbo.QuaTrinhs");
        }
    }
}
