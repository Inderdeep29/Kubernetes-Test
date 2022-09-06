using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ProductExportDataTest
    {
        public string? ProductName { get; set; }
        public string? ProductId { get; set; }
        public int? ComplianceCompanyId { get; set; }
        public string? ExportClassId { get; set; }
        public string? ExportCountry { get; set; }
        public string? ExportDestinationId { get; set; }
        public string? ExportDestinationCountry { get; set; }
        public string? ExportDestinationLicenseRequired { get; set; }
        public string? ExportControlId { get; set; }
        public string? ExportControlCode { get; set; }
        public string? ExportLicenseId { get; set; }
        public string? LicenseId { get; set; }
        public string? ExportLicenseExceptionId { get; set; }
        public string? ExportLicenseExceptionCode { get; set; }
        public string? GaDataId { get; set; }
        public string? GaCode { get; set; }
        public string? GaData { get; set; }
        public string? GaUserDecision { get; set; }
        public string? GaSystemDecision { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
