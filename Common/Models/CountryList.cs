using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class CountryList
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? CountryCode { get; set; }
        public string? UnionCode { get; set; }
        public string? Type { get; set; }
    }
}
