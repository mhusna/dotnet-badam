Console.Write("Sayı: ");
string strSayi = "0" + Console.ReadLine();
int intSayi = int.Parse(strSayi);

string[] birlerBasamagiOkunus = new string[10] { "", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
string[] onlarBasamagiOkunus = new string[10] { "", "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };

string sayiSol = strSayi.Substring(0, 3);
string sayiSag = strSayi.Substring(3,3);

string SayiCevir(string sayi)
{
    //                                      Yuzler                      Onlar                   Birler
    int[] basamaklar = new int[3] { int.Parse("" + sayi[0]), int.Parse("" + sayi[1]), int.Parse("" + sayi[2]) };

    string sonuc = "";

    for (int i = 0; i < 3; i++)
    {
        if (basamaklar[i] != 0)
        {
            if (i == 0)
                sonuc += birlerBasamagiOkunus[basamaklar[i]] + " Yuz";
            else if (i == 1)
                sonuc += onlarBasamagiOkunus[basamaklar[i]];
            else
                sonuc += birlerBasamagiOkunus[basamaklar[i]];
        }
        sonuc += " ";
    }
    return sonuc;
}

string sonuc = $"{SayiCevir(sayiSol)} Bin {SayiCevir(sayiSag)}";
Console.WriteLine(sonuc);