namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qwqer2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Children1",
                c => new
                    {
                        ChildId = c.Int(nullable: false, identity: true),
                        ChildName = c.String(),
                    })
                .PrimaryKey(t => t.ChildId);
            
            CreateTable(
                "dbo.Diseases",
                c => new
                    {
                        DiseaseId = c.Int(nullable: false, identity: true),
                        DiseaseName = c.String(),
                    })
                .PrimaryKey(t => t.DiseaseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Diseases");
            DropTable("dbo.Children1");
        }
    }
}
