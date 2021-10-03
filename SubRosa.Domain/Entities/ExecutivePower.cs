using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SubRosa.Domain.Entities
{
    public partial class ExecutivePower
    {
        public int ExecutivePowerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string Style { get; set; }
        public string Image { get; set; }
    }
}
