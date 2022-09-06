using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class Resource
    {
        public long ResourceId { get; set; }
        public string? Resource1 { get; set; }
        public string? ResourceType { get; set; }
        public string? HttpMethod { get; set; }
    }
}
