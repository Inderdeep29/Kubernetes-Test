using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ProductExportClass
    {
        public string ExportClassId { get; set; } = null!;
        public string? CompanyId { get; set; }
        public int ComplianceStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public string? CommodityDescription { get; set; }
        public string? CountryCode { get; set; }
        public string? Ecn { get; set; }
        public string? ExportHsCode { get; set; }
        public string? ExportUomQtyTuples { get; set; }
        public bool? IsActive { get; set; }
        public string? ProductId { get; set; }
        public int? ComplianceCompanyId { get; set; }
        public string? ClassificationNote { get; set; }
        public string? ClassifiedBy { get; set; }
        public string? EcnClassificationNote { get; set; }
        public string? EcnClassifiedBy { get; set; }
        public DateTime? ClassifiedAt { get; set; }
        public DateTime? EcnClassifiedAt { get; set; }
    }
}
