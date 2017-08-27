namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aweqr3qe44 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cameras", "PhoneId", "dbo.Phones");
            DropIndex("dbo.Cameras", new[] { "PhoneId" });
            CreateTable(
                "dbo.PhoneCameraViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CameraId = c.Int(nullable: false),
                        PhoneName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Cameras", "PhoneId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cameras", "PhoneId", c => c.Int());
            DropTable("dbo.PhoneCameraViewModels");
            CreateIndex("dbo.Cameras", "PhoneId");
            AddForeignKey("dbo.Cameras", "PhoneId", "dbo.Phones", "Id");
        }
    }
}
