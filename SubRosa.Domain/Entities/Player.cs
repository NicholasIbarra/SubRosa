using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SubRosa.Domain.Entities
{
    public partial class Player
    {
        public int PlayerId { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Image { get; set; }
        public string Password { get; set; }
    }
}
