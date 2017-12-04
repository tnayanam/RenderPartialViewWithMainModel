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


/*
 * Suppose we need to go to a previous vverions of the code and fix some bug.
 * But our database is still pointing to the laTEST version, so we need to revert back our migration till that point
 * we will find the latest migration done on that product version where we need to revert back to and then run below command
 * update-database -TargetMigration:dtepublisheddeleted
 * // once this is done our database is reverted back. and now we can go to source repo of our code and revert to that code version we wanted.
 * Now once we fix the stuff we wanted to we SHOLD AGAIN PULL THE LATEST VERSION OF cource code. because that cde only
 * will have the new migration classes and all of that
 * Once that it pulled now we will again run Update-Database and it will bring the DB back to current state
 
     */
