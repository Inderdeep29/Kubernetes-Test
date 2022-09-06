using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ExportConfiguration
    {
        public string Id { get; set; } = null!;
        public string? Code { get; set; }
        public string? CodeType { get; set; }
        public string? CompanyId { get; set; }
        public string? Country { get; set; }
        public string? DestinationCountry { get; set; }
        public string? Expression { get; set; }
        public string? OrgId { get; set; }
        public string? UserDecision { get; set; }
    }
}
