namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wer1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Forms", "age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Forms", "age", c => c.String(nullable: false));
        }
    }
}
