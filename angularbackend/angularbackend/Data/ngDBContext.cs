using angularbackend.Models;
using Microsoft.EntityFrameworkCore;

namespace angularbackend.Data
{
    public class ngDBContext : DbContext
    {
        public ngDBContext(DbContextOptions<ngDBContext> options) : base(options)
        {

        }

        public DbSet<Employees> AngularEmployee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employees>(e =>
            {
                e.HasKey(x => x.id);
                e.ToTable("AngularEmployee");

                e.HasData(
                new Employees { firstName = "Deepak", lastName = "Shakya", email = "d.sha@acc.com", department = "IT" },
                new Employees { firstName = "Shanal", lastName = "Tripathi", email = "shanal.tripathu@acc.com", department = "BDE" },
                new Employees { firstName = "Richa", lastName = "Dubey", email = "richa.dubey@acc.com", department = "Writer" });
            });
        }
    }
}
