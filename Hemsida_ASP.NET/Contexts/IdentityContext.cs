using Hemsida_ASP.NET.Models.Entities;
using Hemsida_ASP.NET.Models.Identities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Hemsida_ASP.NET.Contexts
{
    public class IdentityContext : IdentityDbContext<AppUser>
	{
		public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
		{
		}

		public DbSet<AddressEntity> Addresses { get; set; }
		public DbSet<AccountAddressEntity> AccountAddresses { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			var administratorRole = new IdentityRole
			{
				Id = "1",
				Name = "Administrator",
				NormalizedName = "ADMINISTRATOR"
			};

			var standardUserRole = new IdentityRole
			{
				Id = "2",
				Name = "StandardUser",
				NormalizedName = "STANDARDUSER"
			};

			builder.Entity<IdentityRole>().HasData(administratorRole, standardUserRole);
		}
	}
}
