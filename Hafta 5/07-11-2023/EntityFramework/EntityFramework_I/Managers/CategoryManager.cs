using EntityFramework_I.Data;
using EntityFramework_I.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I.Managers
{
    public class CategoryManager : IGenericManager<Category>
    {
        Context context = new Context();
        public void Add(params Category[] entity)
        {
            foreach (Category category in entity)
                context.Categories.Add(category);
            context.SaveChanges();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return context.Categories.ToList();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }

        public string Display(Category entity)
        {
            return $"{entity.CategoryID}- {entity.CategoryName}";
        }
    }
}
