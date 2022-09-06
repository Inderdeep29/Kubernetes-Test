using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ExceptionClassMap
    {
        public string Id { get; set; } = null!;
        public string? Ecn { get; set; }
        public string? Exceptions { get; set; }
        public string? SourceCountry { get; set; }
    }
}
