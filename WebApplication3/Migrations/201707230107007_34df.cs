namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _34df : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genres", "ArtistId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Genres", "ArtistId");
        }
    }
}
