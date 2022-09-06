using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class LabelTranslation
    {
        public string Id { get; set; } = null!;
        public string? LabelKey { get; set; }
        public string? Language { get; set; }
        public string? Status { get; set; }
        public string? Translation { get; set; }
    }
}
