using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ControlCountryMap
    {
        public string Id { get; set; } = null!;
        public string? Controls { get; set; }
        public string? Country { get; set; }
        public string? DestinationCountry { get; set; }
    }
}
