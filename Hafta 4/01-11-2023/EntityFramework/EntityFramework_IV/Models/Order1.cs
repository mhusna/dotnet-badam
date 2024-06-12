using System;
using System.Collections.Generic;

namespace EntityFramework_IV.Models
{
    public partial class Order1
    {
        public decimal? OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? Country { get; set; }
        public decimal? Amount { get; set; }
    }
}
