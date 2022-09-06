using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class SpiConfiguration
    {
        public string Id { get; set; } = null!;
        public string? CountryCode { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? Preference { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
