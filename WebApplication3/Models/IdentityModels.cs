using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order> Orders { get; set; }
        public virtual ICollection<Document> Documents { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Children> Childrens { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Rain> Rains { get; set; }
        public DbSet<Emp> Emps { get; set; }
        public DbSet<Depot> Depots { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Parking> Parkings { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Website> Websites { get; set; }
        public DbSet<Industry> Industries { get; set; }


        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<WebApplication3.Models.Form> Forms { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plant>()
                .HasMany<Flower>(p => p.Flowers)
                .WithRequired(f => f.Plant)
                .HasForeignKey(k => k.PlantId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Industry>()
                .HasMany<Website>(w => w.Websites)
                .WithRequired(w => w.Industry)
                .HasForeignKey(w => w.IndusId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}