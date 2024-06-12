using EntityFramework_I_Hoca;
using EntityFramework_I_Hoca.Data;
using EntityFramework_I_Hoca.Models;

UrunDB urunDB = new UrunDB();
do
{
    Console.Clear();
    Console.WriteLine("1- Urun Ekle");
    Console.WriteLine("2- Urun Guncelle");
    Console.WriteLine("3- Urun Sil");
    Console.WriteLine("4- Tum Urunleri Listele");
    Console.WriteLine("5- Urun ID'ye Göre Ara");
    Console.WriteLine("6- Kategori Adına Göre Ara");
    Console.WriteLine("7- Tüm Kategoriler");
    Console.WriteLine("8- Kategori Ekle");
    Console.WriteLine("9- Kategori Sil");

    Console.Write("Seciminiz: ");
    int secim = int.Parse(Console.ReadLine());
    int id;
    string eminMisiniz;
    switch (secim)
    {
        case 1:
            urunDB.Urunler.Ekle(ConsoleUtility.UrunVerisiAl());
            break;
        case 2:
            Console.Write("Güncellenecek ürünün id'sini giriniz: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Eski Değerler..");
            Console.WriteLine(urunDB.Urunler.Bul(id));

            Urun urun = ConsoleUtility.UrunVerisiAl();
            urun.UrunID = id;
            urunDB.Urunler.Guncelle(urun);
            break;
        case 3:
            Console.Write("Silinecek ürünün id'sini giriniz: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Ürün Bilgileri..");
            Console.WriteLine(urunDB.Urunler.Bul(id));

            Console.WriteLine("Bu verileri silmek istiyor musunuz ? Evet [e] - Hayır[h]");
            eminMisiniz = Console.ReadLine();

            if(eminMisiniz == "E" || eminMisiniz == "e")
                urunDB.Urunler.Sil(id);
            break;
        case 4:
            ConsoleUtility.Listele(urunDB.Urunler.ListeleJoin("Kategori"));
            Console.ReadLine();
            break;
        case 5:
            Console.Write("Aradığınız ürünün id'sini giriniz: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Ürün Bilgileri..");
            Console.WriteLine(urunDB.Urunler.Bul(id));

            Console.ReadLine();

            break;
        case 6:
            Console.Write("Kategori adını giriniz: ");
            string kategoriAdi = Console.ReadLine();

            var list = urunDB.Urunler.Listele(x => x.Kategori.KategoriAdi.ToLower() == kategoriAdi.ToLower());

            ConsoleUtility.Listele(list);
            Console.ReadLine();
            //ConsoleUtility.Listele(urunDB.Urunler.ListeleJoin("Kategori"));
            break;
        case 7:
            ConsoleUtility.Listele(urunDB.Kategoriler.Listele());
            Console.ReadLine();
            break;
        case 8:
            urunDB.Kategoriler.Ekle(ConsoleUtility.KategoriVerisiAl());
            Console.ReadLine();
            break;
        case 9:
            Console.Write("Silinecek kategorinin id'sini giriniz: ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Kategori Bilgileri..");
            Console.WriteLine(urunDB.Kategoriler.Bul(id));

            Console.WriteLine("Bu verileri silmek istiyor musunuz ? Evet [e] - Hayır[h]");
            eminMisiniz = Console.ReadLine();

            if (eminMisiniz == "E" || eminMisiniz == "e")
                urunDB.Kategoriler.Sil(id);
            break;
        default:
            break;
    }

} while (true);