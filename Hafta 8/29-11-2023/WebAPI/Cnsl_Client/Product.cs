﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cnsl_Client
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }

        public override string ToString()
        {
            return $"{ProductID} - {ProductName} - {Price} - {CategoryID}";
        }
    }
}
