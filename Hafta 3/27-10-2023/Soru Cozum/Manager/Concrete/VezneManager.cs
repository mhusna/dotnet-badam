using Managers.Abstract;
using Model.Concrete;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managers.Concrete
{
    public class VezneManager : IBaseManager<Vezne>
    {
        private List<Vezne> _vezneler = new List<Vezne>();

        public void Ekle(Vezne entity)
        {
            _vezneler.Add(entity);
        }

        public List<Vezne> TumunuGoster()
        {
            return _vezneler;
        }

        public string IslemYap(Vezne vezne)
        {
            vezne.Durum = VezneDurum.Mesgul;
            string islemSonuc = new PersonelManager().IslemYap(vezne.Personel, vezne.Musteri.Islem);
            vezne.Durum = VezneDurum.Musait;
            return islemSonuc;
        }
    }
}
