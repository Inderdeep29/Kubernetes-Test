using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class Product
    {
        public string ProductId { get; set; } = null!;
        public string? CompanyId { get; set; }
        public int ComplianceStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public string? ChildProductIds { get; set; }
        public int? ComponentQty { get; set; }
        public string? CurrencyCode { get; set; }
        public string? CustomsDescription { get; set; }
        public string? Description { get; set; }
        public string? Detailurl { get; set; }
        public string? ExternalProductId { get; set; }
        public double GrossWeight { get; set; }
        public string? Imageurl { get; set; }
        public bool? IsEssentialCharacter { get; set; }
        public string? Name { get; set; }
        public string? OrgId { get; set; }
        public string? ParentProductId { get; set; }
        public double Price { get; set; }
        public string? ProductRef { get; set; }
        public string? ProductType { get; set; }
        public string? ProductUom { get; set; }
        public double UomQty { get; set; }
        public int? ComplianceCompanyId { get; set; }
        public string? ProductCategory { get; set; }
        public string? ProductCategoryInfo { get; set; }
    }
}
