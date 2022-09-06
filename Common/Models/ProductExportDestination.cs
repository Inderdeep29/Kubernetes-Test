using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ProductExportDestination
    {
        public string Id { get; set; } = null!;
        public string? CompanyId { get; set; }
        public int ComplianceStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public string? CountryCode { get; set; }
        public string? DestinationCountryCode { get; set; }
        public string? LicenseRequired { get; set; }
        public string? ProductId { get; set; }
        public int? ComplianceCompanyId { get; set; }
        public bool? LicenseNotAvailable { get; set; }
    }
}
