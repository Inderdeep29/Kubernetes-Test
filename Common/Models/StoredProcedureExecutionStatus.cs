using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class StoredProcedureExecutionStatus
    {
        public string? StoredProcedureName { get; set; }
        public string? Parameters { get; set; }
        public bool? IsRunning { get; set; }
        public DateTime? LastExecutionTime { get; set; }
    }
}
