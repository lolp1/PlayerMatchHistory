namespace PlayerStatistics.Data
{
    public class PlayerStatsService
    {
        public Task<PlayerStats[]> GetPlayerMatchHistoryAsync()
        {
            var randomizer = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new PlayerStats
            {
                Kills = randomizer.Next(10, 20),
                Deaths = randomizer.Next(5, 15),
                DamageDealt = randomizer.Next(15000, 30000),
                DamageTaken = randomizer.Next(15000, 30000),
                GamesWon = randomizer.Next(5, 10),
                GamesLost = randomizer.Next(5, 10),
                TimePlayed = TimeSpan.FromMinutes(randomizer.Next(60, 120))
            }).ToArray());
        }
    }
}
