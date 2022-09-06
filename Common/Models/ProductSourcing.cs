using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ProductSourcing
    {
        public string SourcingId { get; set; } = null!;
        public string? CompanyId { get; set; }
        public int ComplianceStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Coe { get; set; }
        public string? Coo { get; set; }
        public string? CurrencyCode { get; set; }
        public string? ExternalManufacturerId { get; set; }
        public string? ExternalSupplierId { get; set; }
        public string? OrgId { get; set; }
        public double Price { get; set; }
        public string? ProductId { get; set; }
        public int? ComplianceCompanyId { get; set; }
    }
}
