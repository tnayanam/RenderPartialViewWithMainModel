namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class df1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rains");
        }
    }
}
