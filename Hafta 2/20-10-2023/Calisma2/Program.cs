using Calisma2;

List<Personel> personeller = new List<Personel>();

int islem;

do
{
    Console.Clear();
 
    Console.WriteLine("####################");
    Console.WriteLine("1- Rapor Islemleri");
    Console.WriteLine("2- Personel Ekle");
    Console.WriteLine("3- Personel Sil");
    Console.WriteLine("4- Personel Güncelle");
    Console.WriteLine("####################");
    Console.Write("\nYapmak istediğiniz işlemi seçiniz: ");

    islem = int.Parse(Console.ReadLine());

    if (islem == 1)
    {
        Console.Clear();

        Console.WriteLine("a. Tüm Personelleri Getir");
        Console.WriteLine("b. Id'ye Gore Personel Getir");
        Console.WriteLine("c. Aynı İlçede Oturanları Getir");
        Console.Write("\nYapmak istediğiniz işlemi seçiniz: ");

        char raporTipi = char.Parse(Console.ReadLine());

        if (raporTipi == 'a')
        {
            personeller = PersonelManager.TumPersoneller();
            if (personeller.Count != 0)
                PersonelManager.PersonelYazdir(personeller);
            else 
                Console.WriteLine("Sistemde herhangi bir personel bulunmamaktadır.\n");
            Thread.Sleep(1000);
            
        }
        else if (raporTipi == 'b')
        {
            Console.Write("Bulmak istediğiniz personelin id numarası: ");
            Personel personel = PersonelManager.IdyeGorePersonel(int.Parse(Console.ReadLine()));
            if(personel != null)
                PersonelManager.PersonelYazdir(personel);
            else
            {
                Console.WriteLine("Böyle bir id numarasına sahip personel bulunmamaktadır.\n");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
        else
        {
            Console.Write("Adres: ");
            personeller = PersonelManager.AdreseGorePersoneller(Console.ReadLine());
            if (personeller != null)
                PersonelManager.PersonelYazdir(personeller);
            else
            {
                Console.WriteLine("Bu adrese sahip herhangi bir personel bulunmamaktadır.\n");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

    }
    else if (islem == 2)
    {
        Console.Clear();

        Console.Write("Personel Adı: ");
        string ad = Console.ReadLine();
       
        Console.Write("Personel Soyadı: ");
        string soyad = Console.ReadLine();

        Console.Write("Personel Adres: ");
        string adres = Console.ReadLine();

        PersonelManager.PersonelEkle(ad, soyad, adres);

    }
    else if (islem == 3)
    {
        Console.Clear();

        PersonelManager.PersonelYazdir(PersonelManager.TumPersoneller());

        Console.Write("\nSilinecek personelin id numarası: ");
        Personel personel = PersonelManager.IdyeGorePersonel(int.Parse(Console.ReadLine()));
        if(personel != null)
        {
            Console.Write("Silmek istediğine emin misin ?(e/h): ");
            if(char.Parse(Console.ReadLine()) == 'e')
                PersonelManager.PersonelSil(personel);
        }
        else
        {
            Console.WriteLine("Sistemde bu id numarasına sahip bir personel bulunmamaktadır.");
            Thread.Sleep(1000);
        }
    }
    else if (islem == 4)
    {
        Console.Clear();

        Console.Write("Bilgileri güncellenecek personelin id numarası: ");
        int id = int.Parse(Console.ReadLine());

        if(PersonelManager.IdyeGorePersonel(id) != null)
        {
            Console.Write("Ad: ");
            string ad = Console.ReadLine();

            Console.Write("Soyad: ");
            string soyad = Console.ReadLine();

            Console.Write("Adres: ");
            string adres = Console.ReadLine();

            PersonelManager.PersonelGuncelle(id, ad, soyad, adres);
        }
        else
        {
            Console.WriteLine("Sistemde bu id numarasına sahip bir personel bulunmamaktadır.");
            Thread.Sleep(1000);
        }
    }
} while (islem != 5);