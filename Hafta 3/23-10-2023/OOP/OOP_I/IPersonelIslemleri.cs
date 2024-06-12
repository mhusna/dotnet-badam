using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_I
{
    internal interface IPersonelIslemleri
    {
        void Ekle(Personel personel);
        void Guncelle(Personel personel);
        void Sil(int id);
        List<Personel> TumPersoneller();
        List<Personel> AdreseGoreListele(string adres);
        Personel Ara(int id);
    }
}
