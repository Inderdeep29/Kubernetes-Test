using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class UserProfile
    {
        public long UserProfileId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public long? CompanyId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsActive { get; set; }
        public string? Email { get; set; }
        public string? CountryCode { get; set; }
        public string? Language { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public string? UserType { get; set; }
    }
}
