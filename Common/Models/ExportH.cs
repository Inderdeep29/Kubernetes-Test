using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ExportH
    {
        public string Id { get; set; } = null!;
        public string? CountryCode { get; set; }
        public string? Description { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string? ExpiredBy { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? HsCode { get; set; }
        public string? Uom1 { get; set; }
        public string? Uom2 { get; set; }
        public string? Uom3 { get; set; }
        public string? GaCodes { get; set; }
        public bool? IsFinalHs { get; set; }
    }
}
