using Microsoft.EntityFrameworkCore;

using System.Diagnostics;

namespace PlayerStatistics.Data
{
    public class PlayerStatsContext : DbContext
    {
        public static readonly string RowVersion = nameof(RowVersion);

        public static readonly string PlayerStatsDb = nameof(PlayerStatsDb).ToLower();
        public DbSet<PlayerStats>? MatchHistory { get; set; }

        public PlayerStatsContext(DbContextOptions<PlayerStatsContext> options)
    : base(options)
        {
            Debug.WriteLine($"{ContextId} context created.");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // this property isn't on the C# class
            // so we set it up as a "shadow" property and use it for concurrency
            modelBuilder.Entity<PlayerStats>()
                .Property<byte[]>(RowVersion)
                .IsRowVersion();

            base.OnModelCreating(modelBuilder);
        }
    }
}