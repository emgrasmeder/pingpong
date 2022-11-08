using System.ComponentModel.DataAnnotations;

namespace pingpong.Models
{
    public class Game
    {
        public int Id { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime GameDate { get; set; }
        public int? Score { get; set; }
        public string? HomeTeam { get; set; }
        public string? AwayTeam { get; set; }
    }
}