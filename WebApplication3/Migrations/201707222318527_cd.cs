namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Companies", "date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Companies", "date", c => c.DateTime(nullable: false));
        }
    }
}
