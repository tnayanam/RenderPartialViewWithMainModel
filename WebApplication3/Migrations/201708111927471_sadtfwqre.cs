namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sadtfwqre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Industries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Websites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IndusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Industries", t => t.IndusId)
                .Index(t => t.IndusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Websites", "IndusId", "dbo.Industries");
            DropIndex("dbo.Websites", new[] { "IndusId" });
            DropTable("dbo.Websites");
            DropTable("dbo.Industries");
        }
    }
}
