using OOP_I;

PersonelManager personelManager = new PersonelManager();
int secim;
do
{
    Console.WriteLine("Seçenekler: ");
    Console.WriteLine("1- Personel Ekle");
    Console.WriteLine("2- Personel Ara");
    Console.WriteLine("3- Personel Güncelle");
    Console.WriteLine("4- Personel Sil");
    Console.WriteLine("5- Tüm Personeller");
    Console.WriteLine("6- Adrese Göre Tüm Personeller");
    Console.WriteLine("7- Çıkış");

    Console.Write("\nSeçiminiz: ");
    secim = int.Parse(Console.ReadLine());

    Console.Clear();
    switch (secim)
    {
        case 1:
            personelManager.Ekle(ConsolePersonel.PersonelAl());
            break;
        case 2:
            Console.WriteLine(personelManager.Ara(ConsolePersonel.PersonelIdAl()));
            break;
        case 3:
            Console.Write("Güncellenecek kaydın ID'si: ");
            int id = ConsolePersonel.PersonelIdAl();

            Personel personel = personelManager.Ara(id);

            Console.WriteLine(personel);
            Console.WriteLine("Yeni Verileri Giriniz");

            Personel yeniPersonel = ConsolePersonel.PersonelAl();
            yeniPersonel.PersonelID = id;

            personelManager.Guncelle(yeniPersonel);
            break;
        case 4:
            personelManager.Sil(ConsolePersonel.PersonelIdAl());
            break;
        case 5:
            ConsolePersonel.PersonelListele(personelManager.TumPersoneller());
            break;
        case 6:
            Console.Write("Adresi giriniz: ");
            string adres = Console.ReadLine();
            ConsolePersonel.PersonelListele(personelManager.AdreseGoreListele(adres));
            break;
        default:
            break;
    }

} while (secim != 7);