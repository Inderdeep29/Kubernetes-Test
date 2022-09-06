using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class RpsResult
    {
        public string RpsResultsId { get; set; } = null!;
        public DateTime? ScreeningDate { get; set; }
        public string? SystemDecision { get; set; }
        public string? TradingPartyId { get; set; }
        public string? UserComment { get; set; }
        public string? UserDecision { get; set; }
        public DateTime? UserDecisionDate { get; set; }
    }
}
