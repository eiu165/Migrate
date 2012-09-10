using System;
using System.Collections.Generic;

namespace Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string PdfUrl { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> MemberPrice { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }
    }
}
