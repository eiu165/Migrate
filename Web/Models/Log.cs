using System;
using System.Collections.Generic;

namespace Web.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Status { get; set; }
        public string IpAddress { get; set; }
        public string Browser { get; set; }
        public string Server { get; set; }
        public string Session { get; set; }
        public string UserName { get; set; }
        public string Application { get; set; }
        public string Type { get; set; }
        public string Email { get; set; }
        public string Layout { get; set; }
        public System.DateTime UpdatedAt { get; set; }
    }
}
