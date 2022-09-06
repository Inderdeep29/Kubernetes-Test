using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class TradingParty
    {
        public string PartyId { get; set; } = null!;
        public string? CompanyId { get; set; }
        public int ComplianceStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? City { get; set; }
        public string? ContactNumber { get; set; }
        public string? CountryCode { get; set; }
        public string? DecisionBy { get; set; }
        public string? Email { get; set; }
        public string? ExternalPartyId { get; set; }
        public string? Name { get; set; }
        public string? OrgId { get; set; }
        public string? PartyType { get; set; }
        public string? PostalCode { get; set; }
        public string? RpsResultsId { get; set; }
        public string? State { get; set; }
        public string? SystemDecision { get; set; }
        public DateTime? SystemDecisionDate { get; set; }
        public string? SystemNote { get; set; }
        public string? UserDecision { get; set; }
        public DateTime? UserDecisionDate { get; set; }
        public string? UserNote { get; set; }
        public int? ComplianceCompanyId { get; set; }
    }
}
