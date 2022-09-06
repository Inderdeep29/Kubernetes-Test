using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class HsDuty
    {
        public string Id { get; set; } = null!;
        public float AdvaloremRate { get; set; }
        public string? CountryCode { get; set; }
        public string? DutyCompCode { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? HsCode { get; set; }
        public bool IsActive { get; set; }
        public float OtherRate { get; set; }
        public string? PgaCodes { get; set; }
        public float SpecificRate { get; set; }
        public string? Uom1 { get; set; }
        public string? Uom2 { get; set; }
        public string? Uom3 { get; set; }
        public string? PausedBy { get; set; }
        public DateTime? PausedOn { get; set; }
        public string? ExpiredBy { get; set; }
    }
}
