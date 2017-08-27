namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asfre3q : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Workers", "ManagerId", c => c.Int());
            CreateIndex("dbo.Workers", "ManagerId");
            AddForeignKey("dbo.Workers", "ManagerId", "dbo.Managers", "ManagerId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Workers", "ManagerId", "dbo.Managers");
            DropIndex("dbo.Workers", new[] { "ManagerId" });
            DropColumn("dbo.Workers", "ManagerId");
        }
    }
}
