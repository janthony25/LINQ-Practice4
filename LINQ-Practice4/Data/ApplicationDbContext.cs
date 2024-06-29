using LINQ_Practice4.Models;
using Microsoft.EntityFrameworkCore;

namespace LINQ_Practice4.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<tblDepartment> tblDepartment { get; set; }
        public DbSet<tblEmployee> tblEmployee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblEmployee>()
                .HasOne(e => e.tblDepartment)
                .WithMany(d => d.tblEmployee)
                .HasForeignKey(e => e.DepartmentId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
