using System;

namespace GamesBoard.Data.Entities
{
    public class Games
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool FirstTimeDm { get; set; }
        public string Rulebook { get; set; }
        public DateTime StartDate { get; set; } 
        public string Players { get; set; }
    }
}