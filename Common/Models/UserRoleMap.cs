using System;
using System.Collections.Generic;

namespace Common.Models
{
    public partial class UserRoleMap
    {
        public long Id { get; set; }
        public long? UserProfileId { get; set; }
        public long? RoleId { get; set; }
    }
}
