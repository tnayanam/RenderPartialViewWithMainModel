namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sdergdkl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "date");
        }
    }
}
