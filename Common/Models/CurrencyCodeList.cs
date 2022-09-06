using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class CurrencyCodeList
    {
        public string Id { get; set; } = null!;
        public string? Code { get; set; }
        public string? Country { get; set; }
        public string? Currency { get; set; }
        public string? Symbol { get; set; }
    }
}
