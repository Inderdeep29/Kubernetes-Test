using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class Adcvd
    {
        public string Id { get; set; } = null!;
        public string? CaseNumber { get; set; }
        public string? Coe { get; set; }
        public string? Coi { get; set; }
        public string? ConditionLogic { get; set; }
        public string? ControlType { get; set; }
        public string? Coo { get; set; }
        public string? DutyRates { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string? MandateStatus { get; set; }
        public string? Regulation { get; set; }
        public string? Scope { get; set; }
        public string? ScopeException { get; set; }
    }
}
