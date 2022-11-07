using System.ComponentModel.DataAnnotations;

namespace pingpong.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? ScoreTies { get; set; }
        public int? ScoreLosses { get; set; }
        public int? ScoreWins { get; set; }
    }
}