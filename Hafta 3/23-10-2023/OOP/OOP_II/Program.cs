using System.Collections;

DateTime baslat, bitir;

TimeSpan fark, fark2;

ArrayList liste1 = new ArrayList();
List<int> liste2 = new List<int>();

int sayac = 9999999;

baslat = DateTime.Now;
for (int i = 0; i < sayac; i++)
{
    liste1.Add(i); // Burada boxing işlemi yapıyor.
    int sayi = (int)liste1[i]; // Unboxing satırı
}
bitir = DateTime.Now;

fark = bitir - baslat;
Console.WriteLine($"ArrayList: {fark.TotalMilliseconds}");

baslat = DateTime.Now;
for (int i = 0; i < sayac; i++)
{
    liste2.Add(i);
    int sayi = liste2[i];
}
bitir = DateTime.Now;

fark2 = bitir - baslat;
Console.WriteLine($"List: {fark2.TotalMilliseconds}");

Console.WriteLine("*****************");
Console.WriteLine(fark / fark2);