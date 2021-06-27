using VetClinic.Models;
using Microsoft.EntityFrameworkCore;

namespace VetClinic.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {}

        public DbSet<User> users { get; set; }

        public DbSet<Pet> pets { get; set; }

        public DbSet<Visit> visits { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)  
        {  
            base.OnModelCreating(builder);  
        }  
        public override int SaveChanges()  
        {  
            ChangeTracker.DetectChanges();  
            return base.SaveChanges();  
        }
    }
}