using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class Client
    {
        public long ClientId { get; set; }
        public string? ClientSecret { get; set; }
        public string? UserEmail { get; set; }
        public long? ComplianceCompanyId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
