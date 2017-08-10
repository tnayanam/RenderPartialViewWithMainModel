namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdf1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Flowers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PlantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Plants", t => t.PlantId)
                .Index(t => t.PlantId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Flowers", "PlantId", "dbo.Plants");
            DropIndex("dbo.Flowers", new[] { "PlantId" });
            DropTable("dbo.Flowers");
            DropTable("dbo.Plants");
        }
    }
}
