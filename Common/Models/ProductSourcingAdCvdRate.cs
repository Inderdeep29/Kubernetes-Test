using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ProductSourcingAdCvdRate
    {
        public string AdCvdId { get; set; } = null!;
        public string? CompanyId { get; set; }
        public int ComplianceStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public string? CaseNumber { get; set; }
        public string? CountryCode { get; set; }
        public double CvdRate { get; set; }
        public string? ExternalManufacturerId { get; set; }
        public string? ExternalSupplierId { get; set; }
        public string? ProductId { get; set; }
        public string? RateType { get; set; }
        public string? SourcingId { get; set; }
        public int? ComplianceCompanyId { get; set; }
    }
}
