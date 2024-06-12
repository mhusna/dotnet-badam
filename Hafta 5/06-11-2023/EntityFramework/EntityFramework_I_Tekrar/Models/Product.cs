using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I_Tekrar.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public int CategoryID { get; set; }
        public Category? Category { get; set; }

        public override string ToString()
        {
            return $"{ProductID} - {ProductName} - {ProductPrice} - {Category.CategoryName}";
        }
    }
}
