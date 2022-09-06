using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class ExportLicenseExceptionCode
    {
        public string Id { get; set; } = null!;
        public string? CountryCode { get; set; }
        public string? Description { get; set; }
        public string? ExceptionCode { get; set; }
    }
}
