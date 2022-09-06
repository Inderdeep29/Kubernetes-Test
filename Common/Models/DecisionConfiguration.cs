using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class DecisionConfiguration
    {
        public string Id { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? DecisionEntity { get; set; }
        public string? DecisionPreference { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
