namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdfwesd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ManagerWorkerViewModels", "nodefaultbutmanadatory", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ManagerWorkerViewModels", "nodefaultbutmanadatory", c => c.DateTime());
        }
    }
}
