using Microsoft.EntityFrameworkCore;
using Core.Models;

namespace Core.DBContexts
{
    public class CollectionContext : DBContext
    {
        public DbSet<Payment> Payments {get; set;}
        protected override void OnConfiguring(DBContextOptionsBuilder optionsBuilder)
        {
            string conString = "server=localhost; database=transflower; user=root; password= Password";
            optionsBuilder.UseMySql(conString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.PaymentDate).IsRequired();
                entity.Property(e => e.Amount).IsRequired();
                entity.Property(e => e.OrderId).IsRequired();
                entity.Property(e => e.PaymentMode).IsRequired();
            });
        }
    }
}