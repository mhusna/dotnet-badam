using OOP_V_Soru_Hoca;

int secim = 0;
do
{
    Console.WriteLine("*** MENU ***");
    Console.WriteLine("1- Personel Ekle");
    Console.WriteLine("2- Tüm Personeller");
    Console.WriteLine("3- Çıkış");
    Console.WriteLine();

    Console.Write("Seçim: ");
    secim = Convert.ToInt32(Console.ReadLine());

    switch (secim)
    {
        case 1:
            Console.Write("Personel Tipini Giriniz (tz veya yz): ");
            string sec = Console.ReadLine();

            if(sec == "tz")
            {
                TamZamanli tamZamanli = new TamZamanli();
                Console.Write("Personel Adı: ");
                tamZamanli.Ad = Console.ReadLine();

                Console.Write("Personel Soyadı: ");
                tamZamanli.Soyad = Console.ReadLine();

                Console.Write("Personel Taban Ücreti: ");
                tamZamanli.TabanUcret = double.Parse(Console.ReadLine());

                Console.Write("Personel Satış Adeti: ");
                tamZamanli.YaptigiSatis = double.Parse(Console.ReadLine());

                PersonelIslemleri.PersonelEkle(tamZamanli);
            }
            else if(sec == "yz")
            {
                YariZamanli yariZamanli = new YariZamanli();
                Console.Write("Personel Adı: ");
                yariZamanli.Ad = Console.ReadLine();

                Console.Write("Personel Soyadı: ");
                yariZamanli.Soyad = Console.ReadLine();

                Console.Write("Personel Çalıştığı Saat: ");
                yariZamanli.CalistigiSaat = int.Parse(Console.ReadLine());

                Console.Write("Personel Saat Ücreti: ");
                yariZamanli.SaatUcreti = double.Parse(Console.ReadLine());

                Console.Write("Personel Satış Adeti: ");
                yariZamanli.YaptigiSatis = double.Parse(Console.ReadLine());

                PersonelIslemleri.PersonelEkle(yariZamanli);
            }
            Console.WriteLine();
            break;

        case 2:
            foreach (Personel personel in PersonelIslemleri.PersonelListe())
                Console.WriteLine(personel.PersonelVerileri());
            break;

        case 3:
            Console.WriteLine("Program sonlandırıldı. Bay bay...");
            break;

        default:
            Console.WriteLine("1 veya 2 numaralı seçeneklerden birini seçiniz...");
            Console.WriteLine();
            break;
    }


} while (secim != 3);