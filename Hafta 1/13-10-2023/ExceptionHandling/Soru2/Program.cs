/*
    Soru: 1 adet tombala kartı için değerleri oluşturan metodu yazınız. 15 adet sayı, 1-90 arası
 */

int[] SayiOlustur()
{
    int[] sayilar = new int[15];
    Random random = new Random();
    for (int i = 0; i < 15; i++)
    {
        int sayi = random.Next(1, 90);
        if (!sayilar.Contains(sayi))
            sayilar[i] = sayi;
        else
            i--;
    }

    return sayilar;
}

foreach (var item in SayiOlustur())
{
    Console.Write(item + " ");
}
