using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class DocInfo
    {
        public string DocumentId { get; set; } = null!;
        public string? Description { get; set; }
        public string? DocDefinition { get; set; }
        public string? Name { get; set; }
        public string? PageImages { get; set; }
        public string? Type { get; set; }
        public string? DocCode { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
