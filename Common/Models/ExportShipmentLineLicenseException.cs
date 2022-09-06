using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ExportShipmentLineLicenseException
    {
        public string LineItemExceptionId { get; set; } = null!;
        public string? CompanyId { get; set; }
        public int ComplianceStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public string? DecisionBy { get; set; }
        public string? ExceptionCode { get; set; }
        public string? LineId { get; set; }
        public string? RecordMods { get; set; }
        public string? SystemDecision { get; set; }
        public DateTime? SystemDecisionDate { get; set; }
        public string? SystemNote { get; set; }
        public string? UserDecision { get; set; }
        public DateTime? UserDecisionDate { get; set; }
        public string? UserNote { get; set; }
        public int? ComplianceCompanyId { get; set; }
    }
}
