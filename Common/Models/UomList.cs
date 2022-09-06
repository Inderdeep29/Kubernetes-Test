using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class UomList
    {
        public string Id { get; set; } = null!;
        public string? CodeDescription { get; set; }
        public string? Uom { get; set; }
        public string? CountryCode { get; set; }
        public string? CustomsUomCode { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string? ExpiredBy { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
