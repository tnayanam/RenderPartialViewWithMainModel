namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zxce : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Copies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CopyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Copies", t => t.CopyId)
                .Index(t => t.CopyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pages", "CopyId", "dbo.Copies");
            DropIndex("dbo.Pages", new[] { "CopyId" });
            DropTable("dbo.Pages");
            DropTable("dbo.Copies");
        }
    }
}
