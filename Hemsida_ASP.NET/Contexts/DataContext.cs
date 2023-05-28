using Hemsida_ASP.NET.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hemsida_ASP.NET.Contexts
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<ProductEntity> Products { get; set; }
		public DbSet<TagEntity> Tags { get; set; }
		public DbSet<ProductTagEntity> ProductTags { get; set; }
		public DbSet<ContactEntity> Contacts { get; set; }
		public DbSet<ContactMessageEntity> ContactMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

			var tagNew = new TagEntity
			{
				TagId = 1,
				TagName = "New",
			};

            var tagPopular = new TagEntity
            {
                TagId = 2,
                TagName = "Popular",
            };

            var tagFeatured = new TagEntity
            {
                TagId = 3,
                TagName = "Featured",
            };

            modelBuilder.Entity<TagEntity>().HasData(tagNew, tagPopular, tagFeatured);

            var product1 = new ProductEntity
            {
                ArticleId = "A12395B",
                ProductName = "Running Shoes",
                ProductImage = "Image1.jpg",
                Price = 250.00m,
                Ingress = "Fabric shoes perfect for jogging and walking",
                Description = "These running shoes are designed for optimal performance and comfort. With a lightweight and breathable mesh upper, these shoes provide excellent ventilation during intense runs. The cushioned midsole offers responsive and energy-returning support, reducing fatigue and enhancing your stride.",
                VendorName = "Adidas"
            };

            var product2 = new ProductEntity
            {
                ArticleId = "C167452B",
                ProductName = "Wool Hat",
                ProductImage = "Image2.jpg",
                Price = 125.00m,
                Ingress = "75% Pure Wool Hat for winter weather",
                Description = "This woolen winter hat is the perfect accessory to keep you cozy and stylish during cold weather. Made from high-quality, soft wool, this hat offers excellent insulation and warmth. Its thick and plush construction provides superior protection against chilly winds and frosty temperatures. The hat features a snug fit and a foldable cuff, allowing you to adjust the coverage according to your preference.",
                VendorName = "Ellos"
            };

            var product3 = new ProductEntity
            {
                ArticleId = "F129753R",
                ProductName = "Silk Scarf",
                ProductImage = "Image3.jpg",
                Price = 300.00m,
                Ingress = "Silken scarf for summer evenings",
                Description = "The 'SilkGlow' silken scarf is a luxurious accessory that adds elegance and sophistication to any outfit. Made from premium-quality silk, this scarf offers a smooth and soft touch against the skin. Its lightweight and flowing fabric drapes beautifully, creating a graceful and graceful look. The 'SilkGlow' scarf features a vibrant and lustrous sheen that catches the light, adding a touch of glamour to your ensemble.",
                VendorName = "Zara"
            };

            modelBuilder.Entity<ProductEntity>().HasData(product1, product2, product3);

            var productTagEntities = new List<ProductTagEntity>()
             {
                 new ProductTagEntity { ArticleId = "A12395B", TagId = tagFeatured.TagId },
                 new ProductTagEntity { ArticleId = "A12395B", TagId = tagNew.TagId },
                 new ProductTagEntity { ArticleId = "C167452B", TagId = tagFeatured.TagId },
                 new ProductTagEntity { ArticleId = "C167452B", TagId = tagPopular.TagId },
                 new ProductTagEntity { ArticleId = "F129753R", TagId = tagNew.TagId },
                 new ProductTagEntity { ArticleId = "F129753R", TagId = tagPopular.TagId }
             };

            modelBuilder.Entity<ProductTagEntity>().HasData(productTagEntities);
        }
    }
}
