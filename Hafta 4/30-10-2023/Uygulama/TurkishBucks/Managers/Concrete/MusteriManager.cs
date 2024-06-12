using Managers.Abstract;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managers.Concrete
{
    public class MusteriManager : IBaseManager<Musteri>
    {
        private Queue<Musteri> _musteriler = new Queue<Musteri>();
        public void Ekle(Musteri entity)
        {
            _musteriler.Enqueue(entity);
        }

        public List<Musteri> TumunuGetir()
        {
            return _musteriler.ToList();
        }

        public Musteri Cikart()
        {
            if (_musteriler.Count > 0)
                return _musteriler.Dequeue();
            else
                return null;
        }
    }
}
