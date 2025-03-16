using AmtOrk.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AmtOrk.Server.Data;

public class AmtOrkContext : DbContext
{
	public DbSet<Kingdom> Kingdom { get; set; } = default!;
	public DbSet<Land> Land { get; set; } = default!;
	public DbSet<Event> Event { get; set; } = default!;
	public DbSet<Credit> Credit { get; set; } = default!;


	public AmtOrkContext(DbContextOptions<AmtOrkContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

		AmtOrkSeedData.PopulateKingdoms(modelBuilder);
		AmtOrkSeedData.PopulateLands(modelBuilder);
		AmtOrkSeedData.PopulateClasses(modelBuilder);


		modelBuilder.Entity<Classes>().HasIndex(c => c.ClassName).IsUnique();

		modelBuilder.Entity<Credit>().Navigation(c => c.CreditClass).AutoInclude();
		modelBuilder.Entity<Credit>().Navigation(c => c.CreditKingdom).AutoInclude();
		modelBuilder.Entity<Credit>().Navigation(c => c.CreditPark).AutoInclude();
		modelBuilder.Entity<Credit>().Navigation(c => c.CreditEvent).AutoInclude();

		modelBuilder.Entity<Kingdom>().Navigation(k => k.Lands).AutoInclude();
		modelBuilder.Entity<Kingdom>().HasIndex(k => k.KingdomName).IsUnique();
		
    }
}