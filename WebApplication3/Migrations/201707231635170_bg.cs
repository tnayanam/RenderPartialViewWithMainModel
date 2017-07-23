namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bg : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genres", "SongDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Genres", "SongDate");
        }
    }
}
