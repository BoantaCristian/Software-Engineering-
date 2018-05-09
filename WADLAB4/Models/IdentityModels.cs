using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.Migrations;

namespace WADLAB4.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
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
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Specializare> Specs { get; set; }
        public DbSet<Materie> Materii { get; set; }
        public DbSet<Profesor> Profesori { get; set; }
        public DbSet<Nota> Note { get; set; }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }

    internal sealed class DBConfiguration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public DBConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            CommandTimeout = 3000;
        }

    }
}