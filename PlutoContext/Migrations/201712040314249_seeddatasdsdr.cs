namespace PlutoContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seeddatasdsdr : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TagCourses", newName: "CoursesTag");
            RenameColumn(table: "dbo.CoursesTag", name: "Course_Id", newName: "CourseId");
            RenameColumn(table: "dbo.CoursesTag", name: "Tag_Id", newName: "TagId");
            RenameIndex(table: "dbo.CoursesTag", name: "IX_Course_Id", newName: "IX_CourseId");
            RenameIndex(table: "dbo.CoursesTag", name: "IX_Tag_Id", newName: "IX_TagId");
            AlterColumn("dbo.Courses", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "Description", c => c.String());
            RenameIndex(table: "dbo.CoursesTag", name: "IX_TagId", newName: "IX_Tag_Id");
            RenameIndex(table: "dbo.CoursesTag", name: "IX_CourseId", newName: "IX_Course_Id");
            RenameColumn(table: "dbo.CoursesTag", name: "TagId", newName: "Tag_Id");
            RenameColumn(table: "dbo.CoursesTag", name: "CourseId", newName: "Course_Id");
            RenameTable(name: "dbo.CoursesTag", newName: "TagCourses");
        }
    }
}
