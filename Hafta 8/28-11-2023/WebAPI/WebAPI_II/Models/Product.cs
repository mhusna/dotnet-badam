﻿using System;
using System.Collections.Generic;

namespace WebAPI_II.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public double Price { get; set; }
        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; } = null!;
    }
}
