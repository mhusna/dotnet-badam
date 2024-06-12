using SoruCozum.Interfaces;
using SoruCozum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozum
{
    internal class StockManagement : IManagement<Product>
    {
        List<Product> _products = new List<Product>();
        public void Add(Product entity)
        {
            _products.Add(entity);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            foreach (Product entity in _products)
            {
                if(entity.ProductID == id) return entity;
            }
            return null;
        }

        public void Remove(Product entity)
        {
            _products.Remove(entity);
        }

        public void Update(Product entity)
        {
            Remove(GetById(entity.ProductID));
            Add(entity);
        }

        public IEnumerable<Product> BrokenProducts()
        {
            foreach(Product product in _products)
            {
                if(product is IBreakable && ((IBreakable)product).IsBroken)
                    yield return product;
            }
        }

        public IEnumerable<Product> RuinedProducts()
        {
            foreach (Product product in _products)
            {
                if (product is IRuinable && ((IRuinable)product).IsRuined)
                    yield return product;
            }
        }

        public IEnumerable<Product> ExpiredProducts()
        {
            foreach (Product product in _products)
            {
                if(product is ISkt && ((ISkt)product).SKT > DateTime.Now)
                    yield return product;
            }
        }
    }
}
