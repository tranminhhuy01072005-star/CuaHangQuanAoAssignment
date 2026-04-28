using CuaHangQuanAo.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CuaHangQuanAo.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Role> Roles { get; set; }
    
    public DbSet<ProductImage> ProductImages { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Contact> Contacts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // ĐOẠN CODE VẠN NĂNG: Tự động cấu hình tất cả các cột decimal thành (18,2)
        foreach (var property in modelBuilder.Model.GetEntityTypes()
                    .SelectMany(t => t.GetProperties())
                    .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
        {
            property.SetColumnType("decimal(18,2)");
        }

        modelBuilder.Entity<Role>().HasData(
       new Role { Id = 2, Name = "User" }
        );
        modelBuilder.Entity<OrderItem>()
        .Property(o => o.PriceAtPurchase)
        .HasColumnType("decimal(18,2)"); // 18 chữ số, 2 chữ số sau dấu phẩy (phù hợp cho tiền tệ)
        // 1. Cấu hình kiểu dữ liệu cho Price (Để hết bị cảnh báo vàng)
        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasColumnType("decimal(18,2)");

        // 2. Seed dữ liệu mẫu (Giữ nguyên đoạn của Huy)
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Áo Nam" },
            new Category { Id = 2, Name = "Quần " },
            new Category { Id = 3, Name = "Phụ Kiện" }
        );

        // Đừng quên seed luôn Product để tí nữa chạy Web là có đồ xem luôn
        modelBuilder.Entity<Product>().HasData(
    new Product { Id = 1, Name = "Áo LV xám chữ nổi", Price = 1250000, CategoryId = 1, ImageUrl = "/images/0609905f-e19d-4626-90b9-19b39fc25169.jpg", Description = "Hàng cao cấp chữ nổi cực nét", StockQuantity = 50 },
    new Product { Id = 2, Name = "Áo len tay dài boy phố", Price = 450000, CategoryId = 1, ImageUrl = "/images/356b1fa5-1389-4d4c-91bf-47927aad56c8.jpg", Description = "Phong cách boy phố trẻ trung", StockQuantity = 30 },
    new Product { Id = 3, Name = "Áo sơ mi Gucci", Price = 950000, CategoryId = 1, ImageUrl = "/images/c8835fcc-32a7-4902-a0a4-99a27087baa5.jpg", Description = "Sơ mi họa tiết sang chảnh", StockQuantity = 20 },
    new Product { Id = 4, Name = "Áo Mikenko đen hình nổi", Price = 550000, CategoryId = 1, ImageUrl = "/images/cf7bc697-39ad-44f7-b9d3-97629d60d46a.jpg", Description = "Thương hiệu Mikenko chính hãng", StockQuantity = 45 },
    new Product { Id = 5, Name = "Áo Adidas Man United bản đặc biệt", Price = 850000, CategoryId = 1, ImageUrl = "/images/9bab3251-da03-4fd3-973f-ead6791e7973.jpg", Description = "Phiên bản giới hạn cho fan MU", StockQuantity = 15 },
    new Product { Id = 6, Name = "Balo JD Trắng", Price = 650000, CategoryId = 3, ImageUrl = "/images/c17f15fa-5691-4a80-acad-46e77a7e70ac.jpg", Description = "Balo Jordan thời trang", StockQuantity = 25 },
    new Product { Id = 7, Name = "Balo LV Nâu", Price = 1500000, CategoryId = 3, ImageUrl = "/images/ed492643-cecc-4871-ab43-c377e059fc40.jpg", Description = "Họa tiết monogram kinh điển", StockQuantity = 10 },
    new Product { Id = 8, Name = "Quần jean đen trơn", Price = 380000, CategoryId = 2, ImageUrl = "/images/0e66918c-3e38-48e0-a528-01d436e997fe.jpg", Description = "Chất jean co giãn tốt", StockQuantity = 100 },
    new Product { Id = 9, Name = "Quần jean rách gối vẩy sơn", Price = 420000, CategoryId = 2, ImageUrl = "/images/f0b1ebd7-133d-4596-868b-ec80974961f6.jpg", Description = "Phong cách bụi bặm", StockQuantity = 40 },
    new Product { Id = 10, Name = "Quần ống rộng túi hộp", Price = 350000, CategoryId = 2, ImageUrl = "/images/2ae057f9-3f68-4549-bf1a-67945ab121fc.jpg", Description = "Dáng suông thoải mái", StockQuantity = 60 }
);
    }
}