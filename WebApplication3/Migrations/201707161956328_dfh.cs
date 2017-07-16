namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dfh : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Genres", "isUnitNoEmptyInAllRow");
            DropColumn("dbo.Songs", "JSONEncode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Songs", "JSONEncode", c => c.Boolean(nullable: false));
            AddColumn("dbo.Genres", "isUnitNoEmptyInAllRow", c => c.Boolean(nullable: false));
        }
    }
}
