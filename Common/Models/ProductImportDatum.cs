using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ProductImportDatum
    {
        public int? ComplianceCompanyId { get; set; }
        public string? ProductId { get; set; }
        public string? ImportClassId { get; set; }
        public string? CountryCode { get; set; }
        public string? PgaId { get; set; }
        public string? PgaCode { get; set; }
        public string? PgaDataId { get; set; }
        public string? SourcingId { get; set; }
        public string? AdCvdId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CountryOfOrigin { get; set; }
    }
}
