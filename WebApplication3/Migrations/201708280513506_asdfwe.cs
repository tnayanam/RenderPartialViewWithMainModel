namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdfwe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ManagerWorkerViewModels", "nodefaultbutmanadatory", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ManagerWorkerViewModels", "nodefaultbutmanadatory");
        }
    }
}
