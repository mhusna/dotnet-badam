using EntityFramework_I_Hoca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I_Hoca.Data
{
    public class UrunDB
    {
        public BaseManager<Urun> Urunler { get; set; }
        public BaseManager<Kategori> Kategoriler { get; set; }

        public UrunDB()
        {
            Urunler = new BaseManager<Urun>();
            Kategoriler = new BaseManager<Kategori>();
        }
    }
}
