using BookShop_Hoca.Data;
using BookShop_Hoca.Enums;
using BookShop_Hoca.Models;
using BookShop_Hoca.Utilities;
using Microsoft.EntityFrameworkCore;

//Console.Write("Sifre gir: ");
//Console.WriteLine(Utility.SifreMD5(Console.ReadLine()));

var login = Utility.Login();
if (Utility.Login(login))
{
    Console.WriteLine("Kullanıcı var...");

    int secim = 0;
    KitapContext kitapContext = new KitapContext();

    do
    {
        secim = Utility.Menu();

        switch (secim)
        {
            case 1:
                kitapContext.Kitaplar.Add(
                    new Kitap
                    {
                        KitapAdi = "Denemeler",
                        YayinEviID = 1,
                        StokAdedi = 10,
                        KitapDurumu = KitapDurumu.Aktif,
                        Fiyat = 34,
                        EklemeTarihi = DateTime.Now
                    });
                kitapContext.Kitaplar.Add(
                    new Kitap
                    {
                        KitapAdi = "Suc Ve Ceza",
                        YayinEviID = 1,
                        StokAdedi = 2,
                        KitapDurumu = KitapDurumu.Aktif,
                        Fiyat = 54,
                        EklemeTarihi = DateTime.Now
                    });
                kitapContext.Kitaplar.Add(
                    new Kitap
                    {
                        KitapAdi = "Dunya Atlasi",
                        YayinEviID = 1,
                        StokAdedi = 3,
                        KitapDurumu = KitapDurumu.Aktif,
                        Fiyat = 340,
                        EklemeTarihi = DateTime.Now
                    });
                kitapContext.SaveChanges();
                break;
            case 5:
                var result = kitapContext.Kitaplar.Where(x => x.KitapDurumu == KitapDurumu.Aktif).OrderByDescending(x => x.EklemeTarihi).Take(10);
                foreach (var item in result)
                {
                    Console.WriteLine(item.KitapAdi + " " + item.EklemeTarihi);
                }
                break;
            case 6:
                Console.Write("Kitap ID Giriniz: ");
                int id = int.Parse(Console.ReadLine());

                var kitap = kitapContext.Kitaplar.Find(id);
                kitap.KitapDurumu = KitapDurumu.Pasif;
                kitapContext.Entry(kitap).State = EntityState.Modified;
                kitapContext.SaveChanges();
                break;
        }
    }
    while (secim != 10);
}
else
    Console.WriteLine("yok..");