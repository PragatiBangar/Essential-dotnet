using Microsoft.EntityFrameworkCore;
namespace EStoreDBEFApp
{
    public class CollectionContext : DbContext
    {
        public DbSet<Product> Products{get ;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = "server=localhost; user=root; database=transflower ; password=Password";
            optionsBuilder.UseMySQL(conString);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(entity=>
            {
                entity.Haskey(e => e.Id);
                entity.Property(e => e.Title).Isrequired();
                entity.Property(e => e.UnitPrice).Isrequired();
                entity.Property(e => e.Quantity).Isrequired();
            });
        }
    } 
}
