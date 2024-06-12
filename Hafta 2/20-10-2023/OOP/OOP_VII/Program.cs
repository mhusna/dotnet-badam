/*
    Soru: Bir firma için string[], double[], integer[] dizilerdeki değerleri ekrana yazan metodları
    yazınız.
 */

using OOP_VII;

string[] sehiler = { "Ankara", "Bursa", "İstanbul", "İzmir" };
double[] fiyatlar = { 45.99, 66.88, 33.50 };
int[] sayilar = { 45, 56, 78, 32, 4566 };

Utility.YazString(sehiler);
Utility.YazDouble(fiyatlar);
Utility.YazInt(sayilar);

Console.WriteLine();
Console.WriteLine("***************");
Console.WriteLine();

Utility.Yazdir(sehiler);
Utility.Yazdir(fiyatlar);
Utility.Yazdir(sayilar);

Console.WriteLine();
Console.WriteLine("***************");
Console.WriteLine();

// Yazmasan da zaten otomatik anlıyor. Class'larda yazmak zorunlu ama metodlarda değil.
Utility.Yazdir<string>(sehiler);
Utility.Yazdir<double>(fiyatlar);
Utility.Yazdir<int>(sayilar);