/*
    Bilgisayarlar random sayı üretemez, çünkü bilgisayar tanımlı şeyler üzerinde çalışır.


Random random = new Random();
Console.WriteLine(random.Next(100));
 */


/*

Soru: Rastgele oluşturulmuş (1 - 100) arası 50 sayıdan 5'e tam bölünenleri ekrana yazan kodu yazın.

Random random = new Random();
int number;
for (int i = 0; i < 50; i++)
{
    number = random.Next(1, 100);

    if (number % 5 == 0)
        Console.WriteLine(number);
}


// Soru: 10'lu sistemde girilen bir sayıyı 'li sisteme ceviren kodu yazınız.

Console.Write("Sayiyi girin: ");
int number = Int32.Parse(Console.ReadLine());

int kalan;
int bolum;
string binarynum = "";
while(number > 0)
{
    kalan = number % 2;
    number = number / 2;
    binarynum = kalan.ToString() + binarynum;
}

Console.Write(binarynum);

    Hocanın Çözümü
    
    Console.Write("Sayiyi girin: ");
    int number = Int32.Parse(Console.ReadLine());
    
    string sonuc = "";
    while(sayi > 0)
    {
        sonuc = (sayi % 2).ToString() + sonuc;
        sayi = sayi / 2;
    }

    Console.WriteLine(sonuc);


// Soru: Kullanıcının girdiği bir metin ifadeyi; her harf bir satıra gelecek şekilde yazınız.

Console.Write("İfade: ");
string ifade = Console.ReadLine();

for (int i = 0; i < ifade.Length; i++)
{
    Console.WriteLine(ifade[i]);
}

 

// Soru: Kullanıcı tarafından girilmiş olan 5 tamsayıdan en küçüğünü bulan kodu yazınız. (Dizi kullanarak)

int[] number = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.Write((i+1)+". sayı: ");
    number[i] = int.Parse(Console.ReadLine());
}

int enk = number[0];
foreach(int i in number)
{
    if(i < enk)
        enk = i;
}
Console.WriteLine("En küçük: "+ enk);


int[] numbers = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.Write("Sayı: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

Array.Sort(numbers);
Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[4]);

*/

// Soru: 50 kişilik bir sınıf sınav yapılmıştır, öğrencilere 1-10 arası notlar verilmiştir.
// Notların frekansını bulan kodu yazınız.

using System.Linq;

int[] notlarFrekans = new int[10];

for(int i = 0; i < 50; i++)
{
    int not = new Random().Next(1, 11);
    Console.Write(not+" ");
    notlarFrekans[not]++;
}

Console.WriteLine();
foreach (var item in notlarFrekans)
{
    Console.WriteLine(item);
}