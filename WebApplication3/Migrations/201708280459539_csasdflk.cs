namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class csasdflk : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ManagerWorkerViewModels", "ManagerDropdownId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ManagerWorkerViewModels", "ManagerDropdownId", c => c.Int());
        }
    }
}
