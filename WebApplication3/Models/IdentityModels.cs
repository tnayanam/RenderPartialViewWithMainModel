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
        public ICollection<Referral> CandidateReferral { get; set; }
        public ICollection<Referral> ReferrerReferral { get; set; }
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
        public DbSet<Copy> Copies { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Child> Childs { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<MusicType> MusicTypes { get; set; }
        public DbSet<Gig> Gigs { get; set; }
        public DbSet<Instrument> Instruments { get; set; }


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

            modelBuilder.Entity<Copy>()
                .HasMany<Page>(w => w.Pages)
                .WithRequired(w => w.Copy)
                .HasForeignKey(w => w.CopyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(c => c.CandidateReferral)
                .WithOptional(c => c.Candidate) // this wil make foreign key optional
                .HasForeignKey(c => c.CandidateId)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<ApplicationUser>()
                .HasMany(c => c.ReferrerReferral)
                .WithRequired(c => c.Referrer)
                .HasForeignKey(c => c.ReferrerId);

            // one manager can have many workers
            // one worker can exist without a manager too, becase its not assigned.
            modelBuilder.Entity<Manager>()
                .HasMany(m => m.Workers)
                .WithOptional(m => m.Manager)
                .HasForeignKey(m => m.ManagerId);


            //ASSUMPTIONS
            // here we are assuming three things.
            // one musictype can have gigs(song)
            // one song must have a music type
            modelBuilder.Entity<MusicType>()
                .HasMany(c => c.Gigs)
                .WithRequired(c => c.MusicType)
                .HasForeignKey(c => c.MusicTypeId);

            // one instrument can be used in many songs. 
            // and one instrument can exist independetly too
            // a gig can existsw w/o an instrument
            modelBuilder.Entity<Instrument>()
               .HasMany(c => c.Gigs)
               .WithOptional(c => c.Instrument)
               .HasForeignKey(c => c.InstrumentId);

            // one music type can ahve ,any instrumnet
            // on instrument cannot exist w/o a music type

            modelBuilder.Entity<MusicType>()
             .HasMany(c => c.Instruments)
             .WithRequired(c => c.MusicType)
             .HasForeignKey(c => c.MusicTypeId);

            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<WebApplication3.Models.CopyPageViewModel> CopyPageViewModels { get; set; }

        public System.Data.Entity.DbSet<WebApplication3.ViewModel.PhoneCameraViewModel> PhoneCameraViewModels { get; set; }

        public System.Data.Entity.DbSet<WebApplication3.ViewModel.ManagerWorkerViewModel> ManagerWorkerViewModels { get; set; }
    }
}