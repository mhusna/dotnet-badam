using EntityFramework_I_Hoca;
using EntityFramework_I_Hoca.Data;

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

    switch (secim)
    {
        case 1:
            urunDB.Urunler.Ekle(ConsoleUtility.UrunVerisiAl());
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            ConsoleUtility.Listele(urunDB.Urunler.ListeleJoin("Kategori"));
            Console.ReadLine();
            break;
        case 7:
            ConsoleUtility.Listele(urunDB.Kategoriler.Listele());
            Console.ReadLine();
            break;
        case 8:
            urunDB.Kategoriler.Ekle(ConsoleUtility.KategoriVerisiAl());
            Console.ReadLine();
            break;
        default:
            break;
    }

} while (true);