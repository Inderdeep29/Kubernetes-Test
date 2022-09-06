using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ExportShipmentLine
    {
        public string LineId { get; set; } = null!;
        public string? CompanyId { get; set; }
        public int ComplianceStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Description { get; set; }
        public string? DetailUrl { get; set; }
        public string? ExternalProductId { get; set; }
        public string? ImageUrl { get; set; }
        public string? InvoiceId { get; set; }
        public string? InvoiceLineId { get; set; }
        public bool? IsLinked { get; set; }
        public int LineSeq { get; set; }
        public string? Name { get; set; }
        public string? ParentLineId { get; set; }
        public string? PoId { get; set; }
        public string? PoLineId { get; set; }
        public string? ProductCurrencyCode { get; set; }
        public double ProductGrossWeight { get; set; }
        public string? ProductId { get; set; }
        public double ProductPrice { get; set; }
        public double ProductQuantity { get; set; }
        public string? ProductRef { get; set; }
        public string? ProductType { get; set; }
        public string? ProductUom { get; set; }
        public int Quantity { get; set; }
        public string? RecordMods { get; set; }
        public string? ShipmentId { get; set; }
        public string? CommodityDescription { get; set; }
        public string? Ecn { get; set; }
        public string? ExportHsCode { get; set; }
        public string? ExportUomQtyTuples { get; set; }
        public string? LicenseRequired { get; set; }
        public int? ComplianceCompanyId { get; set; }
        public string? ProductCategory { get; set; }
        public string? ProductCategoryInfo { get; set; }
        public string? ClassificationNote { get; set; }
        public string? ClassifiedBy { get; set; }
        public string? EcnClassificationNote { get; set; }
        public string? EcnClassifiedBy { get; set; }
        public bool? LicenseNotAvailable { get; set; }
        public DateTime? ClassifiedAt { get; set; }
        public DateTime? EcnClassifiedAt { get; set; }
    }
}
