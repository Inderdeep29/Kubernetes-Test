using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class SchedulerTask
    {
        public string TaskId { get; set; } = null!;
        public string? TaskName { get; set; }
        public string? TaskType { get; set; }
        public string? TaskParms { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsUserTrigerred { get; set; }
        public string? ExecutionStatus { get; set; }
        public int? ScheduledInterval { get; set; }
    }
}
