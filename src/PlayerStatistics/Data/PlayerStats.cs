namespace PlayerStatistics.Data
{
    public class PlayerStats
    {
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int DamageDealt { get; set; }
        public int DamageTaken { get; set; }
        public int GamesWon { get; set; }
        public int GamesLost { get; set; }
        public int GamesPlayed { get; set; }
        public TimeSpan TimePlayed { get; set; }
    }
}
