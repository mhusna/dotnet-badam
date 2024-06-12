using Managers.Abstract;
using Model.Abstract;
using Model.Concrete;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managers.Concrete
{
    public class PersonelManager : IBaseManager<Personel>
    {
        private List<Personel> _personeller = new List<Personel>();
        public void Ekle(Personel entity)
        {
            _personeller.Add(entity);
        }

        public List<Personel> TumunuGoster()
        {
            return _personeller;
        }

        public string IslemYap(Personel personel, Islem islem)
        {
            personel.Durum = PersonelDurum.Mesgul;
            string islemSonuc = islem.Gerceklestir(personel);
            personel.Durum = PersonelDurum.Musait;

            return islemSonuc;
        }
    }
}
