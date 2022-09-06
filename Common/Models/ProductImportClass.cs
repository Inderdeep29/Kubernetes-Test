using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ProductImportClass
    {
        public string ImportClassId { get; set; } = null!;
        public string? CompanyId { get; set; }
        public int ComplianceStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public string? ClassificationNote { get; set; }
        public string? ClassifiedBy { get; set; }
        public string? CountryCode { get; set; }
        public string? CustomsDescription { get; set; }
        public string? CustomsUomQtyTuples { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string? EndDayAndMonth { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string? HsCode1 { get; set; }
        public string? HsCode2 { get; set; }
        public string? HsCode3 { get; set; }
        public string? HsCode4 { get; set; }
        public bool IsActive { get; set; }
        public string? OrgId { get; set; }
        public string? ProductId { get; set; }
        public string? SeasonalityId { get; set; }
        public string? StartDayAndMonth { get; set; }
        public int? ComplianceCompanyId { get; set; }
        public string? DefaultSourcingId { get; set; }
        public DateTime? ClassifiedAt { get; set; }
    }
}
