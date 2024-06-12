using BookShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Data.Manager
{
    public class KitapManager : BaseManager<Kitap>
    {
        public List<Kitap> YayinEvleriyleGetir()
        {
            return _dbSet.Include(x => x.YayinEvi).ToList();
        }
    }
}
