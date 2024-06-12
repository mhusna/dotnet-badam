using Managers.Abstract;
using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managers.Concrete
{
    public class KasaManager : IBaseManager<Kasa>
    {
        private List<Kasa> _kasalar = new List<Kasa>(3);
        public void Ekle(Kasa entity)
        {
            _kasalar.Add(entity);
        }

        public List<Kasa> TumunuGetir()
        {
            return _kasalar;
        }

        public string SiparisAl(Musteri musteri, Calisan calisan)
        {
            string sonuc = new CalisanManager().Uret(musteri.Siparis, calisan);
            return $"Sipariş tutarı: {musteri.Siparis.Tutar} - "+sonuc;
        }
    }
}
