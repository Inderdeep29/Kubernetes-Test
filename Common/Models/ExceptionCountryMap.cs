using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ExceptionCountryMap
    {
        public string Id { get; set; } = null!;
        public string? Country { get; set; }
        public string? DestinationCountry { get; set; }
        public string? Exceptions { get; set; }
    }
}
