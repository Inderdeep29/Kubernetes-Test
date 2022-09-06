using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class Role
    {
        public long RoleId { get; set; }
        public string? RoleName { get; set; }
        public string? AccessStrategy { get; set; }
    }
}
