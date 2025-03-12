using Microsoft.EntityFrameworkCore;

namespace AmtOrk.Server.Data
{
    public class AmtOrkContext : DbContext
    {
        public AmtOrkContext(DbContextOptions<AmtOrkContext> options) : base(options) {}

        public DbSet<Models.Credit> Credit { get; set; } = default!;
    }
}