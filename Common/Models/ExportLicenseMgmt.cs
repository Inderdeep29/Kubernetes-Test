using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ExportLicenseMgmt
    {
        public string ExportLicenseId { get; set; } = null!;
        public string? CompanyId { get; set; }
        public int ComplianceStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public int ConsumedQuantity { get; set; }
        public double ConsumedValue { get; set; }
        public string? CountryCode { get; set; }
        public string? DestinationCountry { get; set; }
        public string? Ecn { get; set; }
        public DateOnly? ExpirationDate { get; set; }
        public string? LicenseNumber { get; set; }
        public string? LicenseTypeCode { get; set; }
        public int QuantityLimit { get; set; }
        public string? Scope { get; set; }
        public string? Status { get; set; }
        public string? UltimateConsigneeList { get; set; }
        public double ValueLimit { get; set; }
        public int? ComplianceCompanyId { get; set; }
        public bool? HasQuantityLimit { get; set; }
        public bool? HasValueLimit { get; set; }
    }
}
