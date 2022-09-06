using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class CompanyLicenceMap
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public long? LicenceId { get; set; }
    }
}
