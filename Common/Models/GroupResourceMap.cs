using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class GroupResourceMap
    {
        public long Id { get; set; }
        public long? GroupId { get; set; }
        public long? ResourceId { get; set; }
    }
}
