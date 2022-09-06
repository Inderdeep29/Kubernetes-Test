using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ShipmentLineValueAdj
    {
        public string Linevaid { get; set; } = null!;
        public string? CompanyId { get; set; }
        public int ComplianceStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public double AdjustmentAmount { get; set; }
        public string? AdjustmentRef { get; set; }
        public string? AdjustmentType { get; set; }
        public string? CurrencyCode { get; set; }
        public string? Description { get; set; }
        public string? LineId { get; set; }
        public string? RecordMods { get; set; }
        public string? ShipmentId { get; set; }
        public string? ValueType { get; set; }
        public int? ComplianceCompanyId { get; set; }
    }
}
