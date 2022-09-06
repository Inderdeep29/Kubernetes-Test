using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class EntityProcessingQueueConfig
    {
        public long ComplianceCompanyId { get; set; }
        public long QueueConfigId { get; set; }
        public string QueueName { get; set; } = null!;
        public string QueueType { get; set; } = null!;
        public string QueueConfig { get; set; } = null!;
        public DateTime? LoadEndTime { get; set; }
        public DateTime? LoadStartTime { get; set; }
        public DateTime? NextLoadTime { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public int? RecordCount { get; set; }
    }
}
