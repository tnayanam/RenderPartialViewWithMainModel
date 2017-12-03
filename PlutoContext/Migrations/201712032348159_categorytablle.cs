namespace PlutoContext.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class categorytablle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                {
                    Id = c.Int(nullable: false, identity: false), // suppose we need to give our own identity column
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

            // Suppose we want to add data too - sample data
            Sql("INSERT INTO Categories VALUES(1,'Cshapr')");
            Sql("INSERT INTO Categories VALUES(2,'Cplus')");

        }

        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
