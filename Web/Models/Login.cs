using System;
using System.Collections.Generic;

namespace Web.Models
{
    public class Login
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public Nullable<int> FailedAttempts { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string IpAddress { get; set; }
        public string SessionId { get; set; }
    }
}
