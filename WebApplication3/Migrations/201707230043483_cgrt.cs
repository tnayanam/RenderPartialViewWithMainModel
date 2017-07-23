namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cgrt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "Url");
        }
    }
}
