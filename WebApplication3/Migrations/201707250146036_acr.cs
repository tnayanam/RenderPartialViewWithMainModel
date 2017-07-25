namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class acr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parkings", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parkings", "Location");
        }
    }
}
