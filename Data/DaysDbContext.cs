using Microsoft.EntityFrameworkCore;
using OzelGunler.Models;

namespace OzelGunler.Data
{
	public class DaysDbContext : DbContext
	{
		public DaysDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<SpecialDays> OzelGunler { get; set; }

	}
}
