using MehmetHusnaKisla.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Data.Manager
{
    public class AdminManager : BaseManager<Admin>
    {
        public Admin GetByUserNameAndPassword(string userName, string password)
        {
            Admin admin = _dbSet.Where(x => x.UserName == userName && x.Password == password).FirstOrDefault();
            return admin;
        }


        //public Book GetBookByPublisher(int id, string joinEntity)
        //{
        //    return _dbSet.Include(joinEntity).FirstOrDefault();
        //}

        //public override void Delete(int id)
        //{
        //    Book book = GetEntityByID(id);
        //    book.Status = BookStatus.NotForSale;
        //    _context.Entry(book).State = EntityState.Modified;
        //}

    }
}
