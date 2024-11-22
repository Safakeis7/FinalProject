namespace FinalProject.Models
{
    public class BasketballTeams
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateOnly DateFounded { get; set; }
        public string HighestScorer { get; set; } = string.Empty;
        public double OffensiveEfficiency { get; set; }
        public double DefensiveEfficiency { get; set; }

        public BasketballTeams() { }

        public BasketballTeams(int id, string name, DateOnly dateFounded, string highestScorer, double offensiveEfficiency, double defensiveEfficiency)
        {
            Id = id;
            Name = name;
            DateFounded = dateFounded;
            HighestScorer = highestScorer;
            OffensiveEfficiency = offensiveEfficiency;
            DefensiveEfficiency = defensiveEfficiency;
        }
    }
}
