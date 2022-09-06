using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ComplianceCompany
    {
        public long ComplianceCompanyId { get; set; }
        public string? ComplianceCompanyName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long CompanyId { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
