using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managers.Abstract
{
    public interface IBaseManager<T> where T : class
    {
        public List<T> TumunuGoster();
        public void Ekle(T entity);
    }
}
