using System;
using System.Collections.Generic;

namespace RazorDemo.Models
{
    public partial class Salesman
    {
        public Salesman()
        {
            Products = new HashSet<Product>();
        }

        public int Sid { get; set; }
        public string Sname { get; set; } = null!;
        public string? City { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
