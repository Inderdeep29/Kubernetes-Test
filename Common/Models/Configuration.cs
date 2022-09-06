using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class Configuration
    {
        public string Id { get; set; } = null!;
        public string? AddedBy { get; set; }
        public long? ComplianceCompanyId { get; set; }
        public string? ConfigData { get; set; }
        public string? ConfigName { get; set; }
        public string? ConfigSubType { get; set; }
        public string? ConfigType { get; set; }
        public bool? IsActive { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
