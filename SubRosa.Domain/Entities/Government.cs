using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SubRosa.Domain.Entities
{
    public partial class Government
    {
        public int GovernmentId { get; set; }
        public int GameId { get; set; }
        public int RoundNumber { get; set; }
        public int PresidentPlayerId { get; set; }
        public int ChancellorPlayerId { get; set; }
        public int GovernmentOutcomeId { get; set; }
        public int ExecutivePowerGranted { get; set; }
        public int? ExecutivePowerUserOnPlayerId { get; set; }
    }
}
