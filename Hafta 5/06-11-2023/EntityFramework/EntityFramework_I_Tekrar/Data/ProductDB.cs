using EntityFramework_I_Tekrar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I_Tekrar.Data
{
    public class ProductDB
    {
        public GenericRepository<Product> Products { get; set; }
        public GenericRepository<Category> Categories { get; set; }

        public ProductDB()
        {
            Products = new GenericRepository<Product>();
            Categories = new GenericRepository<Category>();
        }
    }
}
