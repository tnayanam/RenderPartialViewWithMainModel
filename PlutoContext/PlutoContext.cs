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
        public virtual DbSet<Mobile> Mobiles { get; set; }
        public virtual DbSet<SIM> SIMs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // CHange Table Name
            // modelBuilder.Entity<Course>()
            //  .ToTable("tbl_abc"); // new name of the table will be tbl_abc

            // Primary Key
            //modelBuilder.Entity<Course>()
            //.HasKey(t => t.Id);
            // Another way to make a field required

            // Composite Key
            //modelBuilder.Entity<Course>()
            //.HasKey(t => new { t.Id,t.Level});

            modelBuilder.Entity<Course>()
                .Property(t => t.Description)
                .IsRequired();

            modelBuilder.Entity<Author>()
                .HasMany(e => e.Courses)
                .WithOptional(e => e.Author)
                .HasForeignKey(e => e.Author_Id);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Courses)
                .Map(m => m.ToTable("TagCourses").MapLeftKey("Course_Id"));

            // One to One relationship
            // Mobile is Principle
            // SIM is dependent
            //modelBuilder.Entity<Mobile>()
            //    .HasRequired(m => m.Sim)
            //    .WithRequiredPrincipal(s => s.Mobile);

            // As long as there is an course linked to an author we should not be able to delete that author 


            //modelBuilder.Entity<Author>()
            //    .HasMany(a => a.Courses)
            //    .WithRequired(c => c.Author)
            //    .HasForeignKey(c => c.Author_Id)
            //    .WillCascadeOnDelete(false);


            // One to Many Relationship

            //modelBuilder.Entity<Author>()
            //    .HasMany(a => a.Courses)
            //    .WithRequired(c => c.Author);

            //modelBuilder.Entity<Author>()
            //    .HasMany(a => a.Courses)
            //    .WithRequired(c => c.Author)
            //    .HasForeignKey(c => c.Author_Id);

            // Many to Many
            //modelBuilder.Entity<Course>()
            //    .HasMany(c => c.Tags)
            //    .WithMany(t => t.Courses);

            // Many to Many with Linking table explicitly named
            // Many to Many
            //modelBuilder.Entity<Course>()
            //    .HasMany(c => c.Tags)
            //    .WithMany(t => t.Courses).
            //    Map(t => t.ToTable("CoursesTag"));
            // in this case the mapping table will be renamed as CoursesTag

            // One to Zero/One
            // course can have no caption or one
            //modelBuilder.Entity<Course>()
            //    .HasOptional(c=>c.Caption)
            //    .WithRequired(c=>c.Course)

            // One to One relationship
            // Here always look for which is parent and which is child
            // for instance in course and cover page, we have one to one. But we cannot have a coverpage w/o the course
            // SO Course table is Parent (Principle) and Cover table is Child (Dependent)
            // Now below is how we define one to one.
            //modelBuilder.Entity<Course>()
            //    .HasRequired(c => c.Cover)
            //    .WithRequiredPrincipal(c => c.Course);
        }
    }
}
