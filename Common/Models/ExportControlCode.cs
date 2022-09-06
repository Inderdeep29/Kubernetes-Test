using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ExportControlCode
    {
        public string Id { get; set; } = null!;
        public string? ControlCode { get; set; }
        public string? CountryCode { get; set; }
        public string? Description { get; set; }
    }
}
