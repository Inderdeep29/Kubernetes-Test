using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class WorkItem
    {
        public string Id { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public string? Data { get; set; }
        public string? Status { get; set; }
        public string? Type { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public long? ComplianceCompanyId { get; set; }
    }
}
