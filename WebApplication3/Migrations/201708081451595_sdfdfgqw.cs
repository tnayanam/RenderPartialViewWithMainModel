namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sdfdfgqw : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Documents", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Documents", new[] { "UserId" });
            AlterColumn("dbo.Documents", "UserId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Documents", "UserId");
            AddForeignKey("dbo.Documents", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Documents", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Documents", new[] { "UserId" });
            AlterColumn("dbo.Documents", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Documents", "UserId");
            AddForeignKey("dbo.Documents", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}
