namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class er : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "onetoten", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "onetoten");
        }
    }
}
