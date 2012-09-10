using System;
using System.Collections.Generic;

namespace Web.Models
{
    public class Role
    {
        public Role()
        {
            this.RoleMemberships = new List<RoleMembership>();
        }

        public int ID { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<RoleMembership> RoleMemberships { get; set; }
    }
}
