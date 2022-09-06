using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class OgaDeterminationConfig
    {
        public string GpaId { get; set; } = null!;
        public string? ApplicableHsRange { get; set; }
        public string? CountryCode { get; set; }
        public string? Description { get; set; }
        public string? GpaName { get; set; }
        public string? ImportExportIndicator { get; set; }
        public string? KeywordList { get; set; }
        public string? PotentialHsRange { get; set; }
        public string? ProductAttr { get; set; }
    }
}
