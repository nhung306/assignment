using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class AssignmentDbContext : DbContext
    {
        public AssignmentDbContext()
        {
        }

        public AssignmentDbContext(DbContextOptions<AssignmentDbContext> options) : base(options)
        { }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>().ToTable("Order").HasKey(x => new { x.CustomerID, x.ProductID });
        }
    }
}