using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class Eccn
    {
        public string Id { get; set; } = null!;
        public string? CountryCode { get; set; }
        public string? Description { get; set; }
        public string? EccnCode { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public string? NodeType { get; set; }
        public string? Notes { get; set; }
        public string? ParentId { get; set; }
        public bool ValidEccn { get; set; }
        public int SortOrder { get; set; }
    }
}
