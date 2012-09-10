using System;
using System.Collections.Generic;

namespace Web.Models
{
    public class Config
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }
    }
}
