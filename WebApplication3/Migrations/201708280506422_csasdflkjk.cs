namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class csasdflkjk : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ManagerWorkerViewModels", "ManagerDropdownId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ManagerWorkerViewModels", "ManagerDropdownId", c => c.Int(nullable: false));
        }
    }
}
