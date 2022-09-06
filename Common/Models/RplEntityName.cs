using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class RplEntityName
    {
        public string NameId { get; set; } = null!;
        public string RplId { get; set; } = null!;
        public string? Name { get; set; }
    }
}
