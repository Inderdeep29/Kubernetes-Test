using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ControlClassMap
    {
        public string Id { get; set; } = null!;
        public string? Control { get; set; }
        public string? ControlFlag { get; set; }
        public string? Country { get; set; }
        public string? Ecn { get; set; }
    }
}
