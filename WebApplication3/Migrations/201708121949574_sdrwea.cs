namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sdrwea : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CopyPageViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PageName = c.String(),
                        CopyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Copies", "CopyName", c => c.String());
            AddColumn("dbo.Pages", "PageName", c => c.String());
            DropColumn("dbo.Copies", "Name");
            DropColumn("dbo.Pages", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pages", "Name", c => c.String());
            AddColumn("dbo.Copies", "Name", c => c.String());
            DropColumn("dbo.Pages", "PageName");
            DropColumn("dbo.Copies", "CopyName");
            DropTable("dbo.CopyPageViewModels");
        }
    }
}
