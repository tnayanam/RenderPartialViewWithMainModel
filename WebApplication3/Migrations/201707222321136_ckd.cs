namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ckd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "EmailAddress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "EmailAddress");
        }
    }
}
