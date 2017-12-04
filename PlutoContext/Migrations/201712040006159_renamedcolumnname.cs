namespace PlutoContext.Migrations
{
    using System.Data.Entity.Migrations;
    // in here we are trying to change a columns name but EF will create a new column and drop the existing one
    // so we will lose all the data of old column so we need copy the old cpolumn data to new column and thne let it drop. so below
    // changes are nmecesary
    public partial class renamedcolumnname : DbMigration
    {
        public override void Up()
        {
            // AddColumn("dbo.Courses", "Name", c => c.String()); // string is nullable type so lets make it non nullable
            AddColumn("dbo.Courses", "Name", c => c.String(nullable: false));

            Sql("UPDATE Courses SET Name = Title");
            DropColumn("dbo.Courses", "Title");
        }

        public override void Down()
        {
            AddColumn("dbo.Courses", "Title", c => c.String(nullable: false));
            Sql("UPDATE Courses SET Title = Name");

            DropColumn("dbo.Courses", "Name");
        }
    }
}
