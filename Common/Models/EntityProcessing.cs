using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class EntityProcessing
    {
        public string RecordId { get; set; } = null!;
        public DateTime? ExecutionTime { get; set; }
        public string? ParentId { get; set; }
        public string? RecordType { get; set; }
        public int? Status { get; set; }
    }
}
