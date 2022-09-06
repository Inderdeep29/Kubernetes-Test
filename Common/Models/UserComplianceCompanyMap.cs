using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class UserComplianceCompanyMap
    {
        public long Id { get; set; }
        public long? UserProfileId { get; set; }
        public long? ComplianceCompanyId { get; set; }
    }
}
