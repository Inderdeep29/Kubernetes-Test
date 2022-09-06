using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ProductExportGaDatum
    {
        public string ExportGaDataId { get; set; } = null!;
        public int? ComplianceCompanyId { get; set; }
        public int ComplianceStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public string? CountryCode { get; set; }
        public string? DecisionBy { get; set; }
        public string? GaCode { get; set; }
        public string? GaData { get; set; }
        public string? ProductId { get; set; }
        public string? SystemDecision { get; set; }
        public DateTime? SystemDecisionDate { get; set; }
        public string? SystemNote { get; set; }
        public string? UserDecision { get; set; }
        public DateTime? UserDecisionDate { get; set; }
        public string? UserNote { get; set; }
    }
}
