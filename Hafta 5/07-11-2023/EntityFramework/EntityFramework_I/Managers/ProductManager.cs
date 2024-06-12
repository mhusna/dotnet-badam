using EntityFramework_I.Data;
using EntityFramework_I.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I.Managers
{
    public class ProductManager : IGenericManager<Product>
    {
        Context context = new Context();
        public void Add(params Product[] entity)
        {
            foreach (Product product in entity)
                context.Products.Add(product);
            context.SaveChanges();
        }

        public void Delete(Product entity)
        {
            context.Products.Remove(entity);
            context.SaveChanges();
        }

        public Product Get(int id)
        {
            return context.Products.FirstOrDefault(product => product.ProductID == id);
        }

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public List<Product> GetAllByCategoryName(string categoryName)
        {
            Category category = context.Categories.FirstOrDefault(category => category.CategoryName == categoryName);
            return context.Products.Where(product => product.CategoryID == category.CategoryID).ToList();
        }

        public void Update(Product entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public string Display(Product entity)
        {
            Product product = context.Products.Include("Category").Where(product => product.ProductID == entity.ProductID).FirstOrDefault();

            return $"{product.ProductID} - {product.ProductName} - {product.Price} - {product.Category.CategoryName}";
        }
    }
}
