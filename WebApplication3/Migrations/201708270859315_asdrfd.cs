namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdrfd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cameras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CameraName = c.String(),
                        PhoneId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Phones", t => t.PhoneId)
                .Index(t => t.PhoneId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cameras", "PhoneId", "dbo.Phones");
            DropIndex("dbo.Cameras", new[] { "PhoneId" });
            DropTable("dbo.Cameras");
            DropTable("dbo.Phones");
        }
    }
}
