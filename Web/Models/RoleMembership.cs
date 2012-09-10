using System;
using System.Collections.Generic;

namespace Web.Models
{
    public class RoleMembership
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
