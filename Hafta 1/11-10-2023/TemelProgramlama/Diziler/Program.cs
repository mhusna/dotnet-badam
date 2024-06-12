/*
    Diziler
    => Aynı tip, boyutu önceden belirlenmiş, içerisindeki verilere indis üzerinden 
    ulaşabileceğimiz, verilerin sıra ile tutulduğu veri yapılarıdır.

    Düzenli Diziler
        => 1 Boyutlu Diziler (Rank = 1)
        => 2 Boyutlu Diziler (Rank = 2)
        => 3 Boyutlu Diziler (Rank = 3)

    Düzensiz Diziler
        => Jagged Array
 

int[] dizi1 = new int[10];
Console.WriteLine(dizi1.Rank);

int[,] dizi2 = new int[10, 10];
Console.WriteLine(dizi2.Rank);

int[,,] dizi3 = new int[10, 10, 10];
Console.WriteLine(dizi3.Rank);

// İki boyutlu hali.
int[][] jaggedArray = new int[5][];
jaggedArray[0] = new int[5];
jaggedArray[1] = new int[10];
jaggedArray[2] = new int[3];

int[][,] jaggedArray2 = new int[5][,];
jaggedArray2[0] = new int[5, 5];
jaggedArray2[1] = new int[10, 3];
jaggedArray2[2] = new int[3, 1];

*/

int[] dizi1 = new int[10];
int[] dizi2 = { 45, 56, 445, 33, 445, 332, 11};

/*
 int sayi = new int();
 Console.WriteLine(sayi);

 Değer tipli tüm değişkenler STRUCT'dır.
 * Struct'lar stack üzerinde tutulur.
 * Struct'lar null değer tutamaz. Tutmak istiyosak nullable(?) hale getirmeliyiz.
 * 
 * char? c = null;
 */

/*
    byte b1 = 0, b2 = 1, b3 = 2;
    b1 = b2 + b3;

    İki byte toplanırsa sonuç int olmalı.
 */

/*
 * Foreach Döngüsü
 * => İndis değişkenine gerek yok.
 * => Koleksiyonun eleman sayısını bilmeye de gerek yok.
 * => Yaklaşma durumuna da gerek yok.
 * => İterasyon değişkeni sadece okunabilirdir.
 * => Üzerinde dolaştığımız dizinin değerleri değiştirilemez.
 */

//foreach (var item in dizi2)
//{
//    Console.WriteLine(item);
//}