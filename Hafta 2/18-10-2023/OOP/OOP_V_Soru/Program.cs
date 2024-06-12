/* 
    Soru: Bir satış firmasında çalışan personeller tam zamanlı ve yarı zamanlı olarak çalışmaktadırlar.
    
    Tam zamanlı personellerin maaşı (taban ücret + prim) şeklinde hesaplanmaktadır. Prim ise; 100.000 TL'ye
    kadar %1, 100.000 ile 250.000 arası %2, 250.000'den büyük ise %3 olarak hesaplanmaktadır.

    Yarı zamanlı personellerin maaşı ise ((çalıştığı saat * saat ücreti) + prim) şeklinde hesaplanmaktadır.
    Yarı zamanlı personellerin yaptığı satışın %1'i prim olarak maaşına yansıtılacaktır.

    Değişik tipte; en az 3 personel için bu maaşları hesaplayan ve gösteren uygulamayı yazınız.
    ** Bu uygulamayı OOP kullanarak yazınız.

    ÇIKTI

    1- Menü
    2- Personel verileri gir (Yarı zamanlı mı tam zamanlı mı sordur.)
    3- Listele
    4- Cikis
*/


using OOP_V_Soru;

int secim;

Personel[] personeller = new Personel[0];

PersonelIslemleri personelIslemleri= new PersonelIslemleri();

do
{

    Console.WriteLine("Menü");
    Console.WriteLine("1- Personel Verileri Gir");
    Console.WriteLine("2- Listele");
    Console.WriteLine("3- Cikis");

    Console.WriteLine();

    Console.Write("Secim: ");

    bool dogruMu = int.TryParse(Console.ReadLine(), out secim);

    if(secim == 1)
    {
        Console.WriteLine();
        Console.WriteLine("4- Tam Zamanli Personel Gir");
        Console.WriteLine("5- Yari Zamanli Personel Gir");

        Console.WriteLine();
        Console.Write("Secim: ");

        dogruMu = int.TryParse(Console.ReadLine(), out secim);

        if(secim == 4)
        {
            TamZamanliPersonel personel = new TamZamanliPersonel();
            Console.WriteLine();
            Console.Write("Personel Adi: ");
            personel.PersonelAdi = Console.ReadLine();

            Console.Write("Satis Adet: ");
            personel.Satis = Convert.ToInt32(Console.ReadLine());

            Console.Write("Taban Maas: ");
            personel.TabanMaas = Convert.ToDouble(Console.ReadLine());

            Array.Resize(ref personeller, personeller.Length + 1);
            personeller[personeller.Length - 1] = personel;
        }

        if(secim == 5)
        {
            YariZamanliPersonel personel = new YariZamanliPersonel();

            Console.Write("Personel Adi: ");
            personel.PersonelAdi = Console.ReadLine();

            Console.Write("Satis Adet: ");
            personel.Satis = Convert.ToInt32(Console.ReadLine());

            Console.Write("Calistigi Saat: ");
            personel.CalistigiSaat = Convert.ToDouble(Console.ReadLine());

            Console.Write("Saat Ucreti: ");
            personel.SaatUcreti = Convert.ToDouble(Console.ReadLine());

            Array.Resize(ref personeller, personeller.Length + 1);
            personeller[personeller.Length - 1] = personel;
        }
    }

    if(secim == 2)
    {
        foreach (var item in personeller)
        {
            Console.WriteLine(new PersonelIslemleri().BilgiGetir(item));
        }
    }

    Console.WriteLine();

} while (secim != 3);