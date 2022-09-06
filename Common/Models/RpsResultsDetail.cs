using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class RpsResultsDetail
    {
        public string RpsResultsDetailsId { get; set; } = null!;
        public string? EntityId { get; set; }
        public double MatchScore { get; set; }
        public string? RecordId { get; set; }
        public string? RecordType { get; set; }
        public string? RpsResultsId { get; set; }
    }
}
