using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class CollaboratorCompany
    {
        public long CollaboratorCompanyId { get; set; }
        public long? ComplianceCompanyId { get; set; }
        public string? CollaboratorType { get; set; }
        public string? TradingPartyId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CollaboratorCompanyName { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
