using Hemsida_ASP.NET.Models.Entities;
using Hemsida_ASP.NET.Models.Identities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hemsida_ASP.NET.Contexts
{
    public class IdentityContext : IdentityDbContext<AppUser>
	{
		public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
		{
		}

		public DbSet<AddressEntity> Addresses { get; set; }
		public DbSet<AccountAddressEntity> AccountAddresses { get; set; }
	}
}
