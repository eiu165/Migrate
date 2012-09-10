using System;
using System.Collections.Generic;

namespace Web.Models
{
    public class User
    {
        public User()
        {
            this.RoleMemberships = new List<RoleMembership>();
        }

        public int ID { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public bool IsApproved { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateLastLogin { get; set; }
        public Nullable<System.DateTime> DateLastActivity { get; set; }
        public System.DateTime DateLastPasswordChange { get; set; }
        public string LastIpAddress { get; set; }
        public string LastSessionId { get; set; }
        public virtual ICollection<RoleMembership> RoleMemberships { get; set; }
    }
}
