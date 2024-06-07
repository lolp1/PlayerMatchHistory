using Microsoft.EntityFrameworkCore;

using PlayerStatistics.Data;

namespace PlayerStatistics
{
    public static class DbUtility
    {
        /// <summary>
        /// Method to see the database. Should not be used in production: demo purposes only.
        /// </summary>
        /// <param name="options">The configured options.</param>
        /// <param name="count">The number of contacts to seed.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public static async Task EnsureDbCreatedAndSeedAsync(DbContextOptions<PlayerStatsContext> options)
        {
            // empty to avoid logging while inserting (otherwise will flood console)
            var factory = new LoggerFactory();
            var builder = new DbContextOptionsBuilder<PlayerStatsContext>(options)
                .UseLoggerFactory(factory);

            using var context = new PlayerStatsContext(builder.Options);
            // result is true if the database had to be created
            if (await context.Database.EnsureCreatedAsync())
            {
                var seed = new PlayerStatsService();
                await seed.SeedDatabaseWithMatchHistory(context);
            }
        }
    }
}