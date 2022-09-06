using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ShipmentExportDatum
    {
        public string? ShipmentId { get; set; }
        public string? CountryOfExport { get; set; }
        public string? CountryOfImport { get; set; }
        public DateOnly? EstimatedExportDate { get; set; }
        public DateOnly? EstimatedImportDate { get; set; }
        public string? LineId { get; set; }
        public string? ExportControlId { get; set; }
        public string? ExportControlCode { get; set; }
        public string? ExportLicenseId { get; set; }
        public string? LicenseId { get; set; }
        public string? ExportLicenseExceptionId { get; set; }
        public string? ExportLicenseExceptionCode { get; set; }
        public bool? IsLinked { get; set; }
        public int? ComplianceCompanyId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateOnly? ExportDate { get; set; }
        public string? ExportLineGaId { get; set; }
    }
}
