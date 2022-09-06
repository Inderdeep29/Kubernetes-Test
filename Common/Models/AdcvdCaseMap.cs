using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class AdcvdCaseMap
    {
        public string Id { get; set; } = null!;
        public string? AdcvdId { get; set; }
        public string? CountryCode { get; set; }
        public string? HsCode { get; set; }
    }
}
