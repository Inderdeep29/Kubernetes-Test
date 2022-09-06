using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class Spi
    {
        public string Id { get; set; } = null!;
        public string? CountryCode { get; set; }
        public string? RateType { get; set; }
        public string? SpiCode { get; set; }
        public string? SpiName { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string? ExpiredBy { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
