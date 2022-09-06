using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class HsTariffMap
    {
        public long Id { get; set; }
        public string? ExportCountryCode { get; set; }
        public string? ImportCountryCode { get; set; }
    }
}
