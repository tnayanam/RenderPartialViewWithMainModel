namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kje : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Types", "Pickle_Id", "dbo.Pickles");
            DropIndex("dbo.Types", new[] { "Pickle_Id" });
            DropColumn("dbo.Types", "Pickle_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Types", "Pickle_Id", c => c.Int());
            CreateIndex("dbo.Types", "Pickle_Id");
            AddForeignKey("dbo.Types", "Pickle_Id", "dbo.Pickles", "Id");
        }
    }
}
