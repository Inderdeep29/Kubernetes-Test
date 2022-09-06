using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class Company
    {
        public long CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
