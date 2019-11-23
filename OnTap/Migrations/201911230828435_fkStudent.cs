namespace OnTap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fkStudent : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.QuaTrinhs", new[] { "sinhVien_ID" });
            DropColumn("dbo.QuaTrinhs", "idStudent");
            RenameColumn(table: "dbo.QuaTrinhs", name: "sinhVien_ID", newName: "idStudent");
            AlterColumn("dbo.QuaTrinhs", "idStudent", c => c.String(maxLength: 128));
            CreateIndex("dbo.QuaTrinhs", "idStudent");
        }
        
        public override void Down()
        {
            DropIndex("dbo.QuaTrinhs", new[] { "idStudent" });
            AlterColumn("dbo.QuaTrinhs", "idStudent", c => c.String());
            RenameColumn(table: "dbo.QuaTrinhs", name: "idStudent", newName: "sinhVien_ID");
            AddColumn("dbo.QuaTrinhs", "idStudent", c => c.String());
            CreateIndex("dbo.QuaTrinhs", "sinhVien_ID");
        }
    }
}
