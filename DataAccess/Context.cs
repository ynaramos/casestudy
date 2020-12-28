using DataAccess.DataModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Colour> Colours { get; set; }

        public DbSet<DiscountType> DiscountTypes { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductAvailability> ProductAvailabilities { get; set; }

        public DbSet<Size> Sizes { get; set; }

        public DbSet<Voucher> Vouchers { get; set; }

        public void AddEntity<T>(T entity) where T : class
        {
            Add(entity);
        }

        public void SetAutoDetectChanges(bool value)
        {
            ChangeTracker.AutoDetectChangesEnabled = value;
        }

        public DbSet<T> Get<T>() where T : class
        {
            ChangeTracker.AutoDetectChangesEnabled = false;

            return Set<T>();
        }

        public void RemoveEntity<T>(T entity) where T : class
        {
            Remove(entity);
        }

        public void UpdateEntity<T>(T entity) where T : class
        {
            Update(entity);
        }

        public void Commit()
        {
            SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder mdBuilder)
        {
            mdBuilder.Entity<Colour>().ToTable("Colour");
            mdBuilder.Entity<DiscountType>().ToTable("DiscountType");
            mdBuilder.Entity<Product>().ToTable("Product");
            mdBuilder.Entity<ProductAvailability>().ToTable("ProductAvailability");
            mdBuilder.Entity<Size>().ToTable("Size");
            mdBuilder.Entity<Voucher>().ToTable("Voucher");
        }
    }
}
