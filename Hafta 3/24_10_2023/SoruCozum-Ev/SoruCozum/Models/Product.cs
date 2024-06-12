using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozum.Models
{
    internal abstract class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price  { get; set; }
    }
}
