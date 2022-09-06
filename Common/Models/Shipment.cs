using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class Shipment
    {
        public string ShipmentId { get; set; } = null!;
        public string? CompanyId { get; set; }
        public int ComplianceStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Coe { get; set; }
        public string? Coi { get; set; }
        public DateOnly? EstimatedExportDate { get; set; }
        public DateOnly? EstimatedImportDate { get; set; }
        public string? ExternalShipmentId { get; set; }
        public string? IncoTerms { get; set; }
        public string? ModeOfTransport { get; set; }
        public string? OrgId { get; set; }
        public int? ComplianceCompanyId { get; set; }
    }
}
