using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class RoleGroupMap
    {
        public long Id { get; set; }
        public long? GroupId { get; set; }
        public long? RoleId { get; set; }
    }
}
