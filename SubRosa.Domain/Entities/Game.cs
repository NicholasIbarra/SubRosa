using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SubRosa.Domain.Entities
{
    public partial class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? RoundNumber { get; set; }
        public int HostPlayerId { get; set; }
        public int GameStateId { get; set; }
        public int? ElectionTracker { get; set; }
        public int? WinningMembershipId { get; set; }
        public int? CurrentPresidentPlayerId { get; set; }
        public int? CurrentChancellorPlayerId { get; set; }
        public int TotalLiberalPolicies { get; set; }
        public int TotalFascistPolicies { get; set; }
        public int TotalLiberalPlayers { get; set; }
        public int TotalFascistPlayers { get; set; }
    }
}
