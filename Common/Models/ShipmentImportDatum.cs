using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ShipmentImportDatum
    {
        public string? ShipmentId { get; set; }
        public int? ComplianceCompanyId { get; set; }
        public string? CountryOfImport { get; set; }
        public DateOnly? ImportDate { get; set; }
        public string? LineId { get; set; }
        public bool? IsLinked { get; set; }
        public string? ProductId { get; set; }
        public string? ProductType { get; set; }
        public string? Lineadcvdid { get; set; }
        public string? AdcvdSystemDecision { get; set; }
        public string? AdcvdUserDecision { get; set; }
        public string? Linegaid { get; set; }
        public string? GaCode { get; set; }
        public string? GaSystemDecision { get; set; }
        public string? GaUserDecision { get; set; }
        public string? Linevaid { get; set; }
    }
}
