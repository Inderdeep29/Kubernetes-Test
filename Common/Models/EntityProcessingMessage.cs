using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class EntityProcessingMessage
    {
        public string EntityProcessingMessageId { get; set; } = null!;
        public string? FieldName { get; set; }
        public string? Msg { get; set; }
        public string? MsgCode { get; set; }
        public int? MsgSeverity { get; set; }
        public string? RecordId { get; set; }
        public string? RuleId { get; set; }
        public string? MsgContext { get; set; }
    }
}
