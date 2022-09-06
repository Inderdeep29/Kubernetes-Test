using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class LicenceGroupMap
    {
        public long Id { get; set; }
        public long? GroupId { get; set; }
        public long? LicenceId { get; set; }
    }
}
