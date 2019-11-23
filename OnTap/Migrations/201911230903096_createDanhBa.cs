namespace OnTap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDanhBa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DanhBas",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        idStudent = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SinhViens", t => t.idStudent)
                .Index(t => t.idStudent);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DanhBas", "idStudent", "dbo.SinhViens");
            DropIndex("dbo.DanhBas", new[] { "idStudent" });
            DropTable("dbo.DanhBas");
        }
    }
}
