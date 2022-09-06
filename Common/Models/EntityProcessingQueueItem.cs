using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class EntityProcessingQueueItem
    {
        public long QueueItemId { get; set; }
        public string QueueName { get; set; } = null!;
        public string QueueType { get; set; } = null!;
        public string RecordId { get; set; } = null!;
        public string RecordType { get; set; } = null!;
        public long QueueIndex { get; set; }
        public DateTime? QueuedTime { get; set; }
        public long ComplianceCompanyId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
