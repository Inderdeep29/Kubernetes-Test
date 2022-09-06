using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class HsSpiDuty
    {
        public string Id { get; set; } = null!;
        public float AdvaloremRate { get; set; }
        public string? HsId { get; set; }
        public float OtherRate { get; set; }
        public float SpecificRate { get; set; }
        public string? SpiCode { get; set; }
    }
}
