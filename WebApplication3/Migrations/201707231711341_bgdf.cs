namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bgdf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genres", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Genres", "Image");
        }
    }
}
