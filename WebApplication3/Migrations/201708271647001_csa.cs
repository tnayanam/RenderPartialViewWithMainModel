namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class csa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ManagerWorkerViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkerName = c.String(),
                        ManagerId = c.Int(),
                        dateTime = c.DateTime(nullable: false),
                        dateTimeNoDefault = c.DateTime(),
                        ManagerDropdownId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ManagerWorkerViewModels");
        }
    }
}
