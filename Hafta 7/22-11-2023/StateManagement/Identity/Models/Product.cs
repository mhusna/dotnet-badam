using System;
using System.Collections.Generic;

namespace Identity.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public string? Imagepath { get; set; }
        public string? ImagePath1 { get; set; }
        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual Category? Category { get; set; }
    }
}
