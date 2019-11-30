namespace OnTap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateSV : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SinhViens", "TenDangNhap", c => c.String());
            AddColumn("dbo.SinhViens", "MatKhau", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SinhViens", "MatKhau");
            DropColumn("dbo.SinhViens", "TenDangNhap");
        }
    }
}
