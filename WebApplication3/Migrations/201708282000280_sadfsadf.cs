namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sadfsadf : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MusicTypes",
                c => new
                    {
                        MusicTypeId = c.Int(nullable: false, identity: true),
                        MusicTypeName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MusicTypeId);
            
            CreateTable(
                "dbo.Gigs",
                c => new
                    {
                        GigId = c.Int(nullable: false, identity: true),
                        GigName = c.String(nullable: false),
                        MusicTypeId = c.Int(nullable: false),
                        InstrumentId = c.Int(),
                    })
                .PrimaryKey(t => t.GigId)
                .ForeignKey("dbo.Instruments", t => t.InstrumentId)
                .ForeignKey("dbo.MusicTypes", t => t.MusicTypeId, cascadeDelete: true)
                .Index(t => t.MusicTypeId)
                .Index(t => t.InstrumentId);
            
            CreateTable(
                "dbo.Instruments",
                c => new
                    {
                        InstrumentId = c.Int(nullable: false, identity: true),
                        InstrumentName = c.String(nullable: false),
                        MusicTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InstrumentId)
                .ForeignKey("dbo.MusicTypes", t => t.MusicTypeId, cascadeDelete: true)
                .Index(t => t.MusicTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Instruments", "MusicTypeId", "dbo.MusicTypes");
            DropForeignKey("dbo.Gigs", "MusicTypeId", "dbo.MusicTypes");
            DropForeignKey("dbo.Gigs", "InstrumentId", "dbo.Instruments");
            DropIndex("dbo.Instruments", new[] { "MusicTypeId" });
            DropIndex("dbo.Gigs", new[] { "InstrumentId" });
            DropIndex("dbo.Gigs", new[] { "MusicTypeId" });
            DropTable("dbo.Instruments");
            DropTable("dbo.Gigs");
            DropTable("dbo.MusicTypes");
        }
    }
}
