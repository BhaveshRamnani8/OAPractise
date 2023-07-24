using Microsoft.EntityFrameworkCore;
using OA.Data;

namespace OA.Repo
{
    public class OAContext : DbContext
    {
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Country>? Country { get; set; }
        public DbSet<State>? State { get; set; }
        public DbSet<City>? City { get; set; }

        public OAContext(DbContextOptions<OAContext> options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            new EmployeeMap(modelBuilder.Entity<Employee>());            
        }
    }
}