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

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Colour>().ToTable("Colour");

            /*** DISCOUNT TYPE ***/
            builder.Entity<DiscountType>().HasKey(x => x.ID).HasName("PK_DiscountType");
            builder.Entity<DiscountType>().Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Entity<DiscountType>().Property(x => x.Description).IsRequired().HasMaxLength(150);
            builder.Entity<DiscountType>().ToTable("DiscountType");

            /*** PRODUCT ***/
            builder.Entity<Product>().HasKey(x => x.ID).HasName("PK_Product");
            builder.Entity<Product>().Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(x => x.ShoeName).IsRequired().HasMaxLength(150);
            builder.Entity<Product>().Property(x => x.PhotoFilepath).IsRequired().HasMaxLength(250);
            builder.Entity<Product>().Property(x => x.Description).IsRequired().HasMaxLength(600);
            builder.Entity<Product>().ToTable("Product");

            /*** PRODUCT AVAILABILITY ***/
            builder.Entity<ProductAvailability>().HasKey(x => new { x.ProductID, x.SizeID }).HasName("PK_ProductAvailability");
            builder.Entity<ProductAvailability>().HasOne(x => x.Product)
                .WithMany(x => x.ProductAvailabilities)
                .HasForeignKey(x => x.ProductID)
                .HasConstraintName("FK_ProductAvailability_Product");
            builder.Entity<ProductAvailability>().HasOne(x => x.Size)
                .WithMany(x => x.SizeAvailabilities)
                .HasForeignKey(x => x.SizeID)
                .HasConstraintName("FK_ProductAvailability_Size");
            builder.Entity<ProductAvailability>().ToTable("ProductAvailability");

            /*** Shopping Cart Item ***/
            builder.Entity<ShoppingCartItem>().HasKey(x => new { x.ProductID, x.SizeID }).HasName("PK_ShoppingCartItem");
            builder.Entity<ShoppingCartItem>().HasOne(x => x.Product)
                .WithMany(x => x.ShoppingCartItems)
                .HasForeignKey(x => x.ProductID)
                .HasConstraintName("FK_ShoppingCartItem_Product");
            builder.Entity<ShoppingCartItem>().HasOne(x => x.Size)
                .WithMany(x => x.ShoppingCartItems)
                .HasForeignKey(x => x.SizeID)
                .HasConstraintName("FK_ShoppingCartItem_Size");
            builder.Entity<ShoppingCartItem>().ToTable("ShoppingCartItem");

            /*** SIZE ***/
            builder.Entity<Size>().HasKey(x => x.ID).HasName("PK_Size");
            builder.Entity<Size>().Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Entity<Size>().ToTable("Size");

            /*** VOUCHER ***/
            builder.Entity<Voucher>().HasKey(x => x.ID).HasName("PK_Voucher");
            builder.Entity<Voucher>().Property(x => x.ID).ValueGeneratedNever();
            builder.Entity<Voucher>().HasOne(x => x.Discount)
                .WithMany(x => x.Vouchers)
                .HasForeignKey(x => x.DiscountTypeID)
                .HasConstraintName("FK_Voucher_DiscountType");
            builder.Entity<Voucher>().ToTable("Voucher");
        }
    }
}
