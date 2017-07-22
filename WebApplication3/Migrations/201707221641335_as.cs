namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _as : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Depots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Emps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpName = c.String(),
                        DepotId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Depots", t => t.DepotId, cascadeDelete: true)
                .Index(t => t.DepotId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Emps", "DepotId", "dbo.Depots");
            DropIndex("dbo.Emps", new[] { "DepotId" });
            DropTable("dbo.Emps");
            DropTable("dbo.Depots");
        }
    }
}
