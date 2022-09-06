using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class CollaboratorRequestItem
    {
        public string CollaboratorRequestItemId { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public long? ComplianceCompanyId { get; set; }
        public string? RequestSourceData { get; set; }
        public string? RequestSourceKey { get; set; }
        public string? RequestSourceType { get; set; }
        public string? Status { get; set; }
        public string? TradingPartyId { get; set; }
    }
}
