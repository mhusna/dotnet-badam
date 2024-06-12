using Managers.Abstract;
using Model.Concrete;
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

        public Musteri MusteriCikar()
        {
            if (_musteriler.Count > 0)
               return _musteriler.Dequeue();
            return null;
        }

        public List<Musteri> TumunuGoster()
        {
            return _musteriler.ToList();
        }

        public void BankayaGit(Musteri musteri)
        {
            Ekle(musteri);
        }
    }
}
