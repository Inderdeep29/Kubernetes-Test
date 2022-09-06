using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ProductAd
    {
        public string AdCvdId { get; set; } = null!;
        public string? CompanyId { get; set; }
        public int ComplianceStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public double AllOthersCvdRate { get; set; }
        public string? CaseNumber { get; set; }
        public string? Coo { get; set; }
        public string? CountryCode { get; set; }
        public string? DecisionBy { get; set; }
        public string? ProductId { get; set; }
        public string? SystemDecision { get; set; }
        public DateTime? SystemDecisionDate { get; set; }
        public string? SystemNote { get; set; }
        public string? UserDecision { get; set; }
        public DateTime? UserDecisionDate { get; set; }
        public string? UserNote { get; set; }
        public int? ComplianceCompanyId { get; set; }
    }
}
