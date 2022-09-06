using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class PgaFormMap
    {
        public string Id { get; set; } = null!;
        public string? FormCode { get; set; }
        public string? FormName { get; set; }
        public string? FormType { get; set; }
        public string? PgaCode { get; set; }
    }
}
