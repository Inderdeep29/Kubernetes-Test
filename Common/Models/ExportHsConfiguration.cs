using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ExportHsConfiguration
    {
        public string Id { get; set; } = null!;
        public string CountryCode { get; set; } = null!;
        public string HsLength { get; set; } = null!;
        public int? ComplianceCompanyId { get; set; }
        public string? AddedBy { get; set; }
        public bool? IsValid { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
