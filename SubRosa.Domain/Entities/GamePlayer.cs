using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SubRosa.Domain.Entities
{
    public partial class GamePlayer
    {
        public int GamePlayerId { get; set; }
        public int GameId { get; set; }
        public int PlayerId { get; set; }
        public bool? IsReadToStart { get; set; }
        public int MembershipId { get; set; }
        public int MembershipRoleId { get; set; }
        public bool? IsExecuted { get; set; }
        public int? ElectionVote { get; set; }
    }
}
