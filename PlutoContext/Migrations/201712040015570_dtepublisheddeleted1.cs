namespace PlutoContext.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class dtepublisheddeleted1 : DbMigration
    {
        // here are are trying to drop a class but before dropping we are creating a back up in a separate table, note
        // thgat we need to change the down functrion accordingly too.
        public override void Up()
        {
            CreateTable(
               "dbo._Categories",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Name = c.String(),
               })
               .PrimaryKey(t => t.Id);
            Sql("INSERT INTO _Categories (Name) SELECT Name FROM Categories");
            DropTable("dbo.Categories");

        }

        public override void Down()
        {

            CreateTable(
                "dbo.Categories",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO Categories (Name) SELECT Name FROM _Categories");
            DropTable("dbo._Categories");

        }
    }
}
