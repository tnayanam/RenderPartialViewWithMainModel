namespace PlutoContext
{
    using System.Data.Entity;

    // Try to keep this class name same as the one in connection string. If it is the same then we do not need to change
    // our connection string, or we do not even need to pass "name=PlutoContext" in the constructor
    // However if these name does not match then we need to see what is the KEY name in the connection string
    // and we need to pass that name here in the constrcutor of this class "name=CONNECTIONSTRINTGLKEY"

    public partial class PlutoContext : DbContext
    {
        public PlutoContext()
            : base("name=PlutoContext")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(e => e.Courses)
                .WithOptional(e => e.Author)
                .HasForeignKey(e => e.Author_Id);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Courses)
                .Map(m => m.ToTable("TagCourses").MapLeftKey("Course_Id"));
        }
    }
}
