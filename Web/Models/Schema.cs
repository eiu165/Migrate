using System;
using System.Collections.Generic;

namespace Web.Models
{
    public class Schema
    {
        public int Id { get; set; }
        public long Version { get; set; }
        public Nullable<System.DateTime> UtcDate { get; set; }
        public string BuildNumber { get; set; }
        public string Status { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }
    }
}
