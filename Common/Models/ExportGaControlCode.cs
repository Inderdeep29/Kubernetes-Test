using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ExportGaControlCode
    {
        public string Id { get; set; } = null!;
        public string? Agency { get; set; }
        public string? ControlCode { get; set; }
        public string? CountryCode { get; set; }
        public string? Description { get; set; }
        public string? FormCode { get; set; }
        public string? Required { get; set; }
        public string? BaseControlCode { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string? ExpiredBy { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? DestinationCountryFlag { get; set; }
        public string? DestinationCountryList { get; set; }
    }
}
