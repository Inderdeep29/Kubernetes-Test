using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ProductPgaDatum
    {
        public string PgaDataId { get; set; } = null!;
        public string? CompanyId { get; set; }
        public int ComplianceStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public string? CountryCode { get; set; }
        public string? ExternalManufacturerId { get; set; }
        public string? ExternalSupplierId { get; set; }
        public string? OrgId { get; set; }
        public string? PgaCode { get; set; }
        public string? PgaData { get; set; }
        public string? ProductId { get; set; }
        public string? SourcingId { get; set; }
        public int? ComplianceCompanyId { get; set; }
    }
}
