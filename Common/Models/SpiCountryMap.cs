using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class SpiCountryMap
    {
        public string Id { get; set; } = null!;
        public string? CountryCode { get; set; }
        public string? SpiCode { get; set; }
        public string? SpiMemberCountryCode { get; set; }
    }
}
