/*
    Soru: Liste içerisindeki çift sayıları bulunuz.
 */

// Yöntem 1
List<int> sayilar = new List<int>() { 34, 45, 6, 7, 88, 33, 145, 777};

foreach (int sayi in sayilar)
{
    if (sayi % 2 == 0)
        Console.Write($" {sayi} ");
}

// Ara metotlar
void Yazdir(List<int> sayilar)
{
    foreach (int sayi in sayilar)
        Console.Write(sayi + " ");
}

bool CiftSayilar(int sayi)
{
    return sayi % 2 == 0; // Karşılaştırma operatörü bool tipinde değer döndürdüğü için if'e gerek yok.
}

bool TekSayilar(double sayi)
{
    return sayi % 2 == 1;
}

// Yöntem 2
Console.WriteLine("\n******************************");
Predicate<int> predicate = new Predicate<int>(CiftSayilar);
sayilar.FindAll(predicate);
Yazdir(sayilar.FindAll(predicate));

// Yöntem 3: Eğer delegeyi gördüysem uzun uzun yazmaya gerek yok.
Console.WriteLine("\n******************************");
sayilar.FindAll(CiftSayilar);
Yazdir(sayilar.FindAll(CiftSayilar));

/*
    Metodun imzası ile delegenin imzası aynı olmadığı için hata verir.
    sayilar listesi int dolayısı ile FindAll da int. Ama gönderilen parametre
    double. 

    Yazdir(sayilar.FindAll(TekSayilar)); 
*/

// Yöntem 4
Console.WriteLine("\n******************************");
Yazdir(sayilar.FindAll(delegate(int sayi) { return sayi % 2 == 0; }));

// Yöntem 5
Console.WriteLine("\n******************************");
Yazdir(sayilar.FindAll(sayi => sayi % 2 == 0));