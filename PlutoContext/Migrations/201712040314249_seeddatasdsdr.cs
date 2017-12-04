namespace PlutoContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seeddatasdsdr : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Courses", newName: "tbl_abc");
            AlterColumn("dbo.tbl_abc", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tbl_abc", "Description", c => c.String());
            RenameTable(name: "dbo.tbl_abc", newName: "Courses");
        }
    }
}
