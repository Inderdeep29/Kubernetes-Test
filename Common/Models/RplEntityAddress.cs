using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class RplEntityAddress
    {
        public string AddressId { get; set; } = null!;
        public string RplId { get; set; } = null!;
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? City { get; set; }
        public string? CountryCode { get; set; }
        public string? PostalCode { get; set; }
        public string? State { get; set; }
    }
}
