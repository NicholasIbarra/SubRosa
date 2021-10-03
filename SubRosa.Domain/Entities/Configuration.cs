using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SubRosa.Domain.Entities
{
    public partial class Configuration
    {
        public int ConfigurationId { get; set; }
        public string Name { get; set; }
        public int TotalPlayers { get; set; }
        public int TotalLiberalPlayers { get; set; }
        public int TotalFascistPlayers { get; set; }
        public string FascistBoard { get; set; }
        public int ExecutivePower1 { get; set; }
        public int ExecutivePower2 { get; set; }
        public int ExecutivePower3 { get; set; }
        public int ExecutivePower4 { get; set; }
        public int ExecutivePower5 { get; set; }
    }
}
