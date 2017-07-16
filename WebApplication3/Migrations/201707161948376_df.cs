namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class df : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genres", "isUnitNoEmptyInAllRow", c => c.Boolean(nullable: false));
            AddColumn("dbo.Songs", "JSONEncode", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Songs", "JSONEncode");
            DropColumn("dbo.Genres", "isUnitNoEmptyInAllRow");
        }
    }
}
