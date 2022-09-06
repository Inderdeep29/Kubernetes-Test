using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class EntityProcessingDatum
    {
        public string? RecordId { get; set; }
        public string? ParentId { get; set; }
        public string? RecordType { get; set; }
        public string? MsgCode { get; set; }
    }
}
