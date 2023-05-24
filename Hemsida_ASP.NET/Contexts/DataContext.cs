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
        }
    }
}
