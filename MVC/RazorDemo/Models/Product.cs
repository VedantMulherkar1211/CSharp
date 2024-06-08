using System;
using System.Collections.Generic;

namespace RazorDemo.Models
{
    public partial class Product
    {
        public int Pid { get; set; }
        public string? Pname { get; set; }
        public float? Price { get; set; }
        public int? Qty { get; set; }
        public int? Cid { get; set; }
        public int? Sid { get; set; }

        public virtual Category? CidNavigation { get; set; }
        public virtual Salesman? SidNavigation { get; set; }
    }
}
