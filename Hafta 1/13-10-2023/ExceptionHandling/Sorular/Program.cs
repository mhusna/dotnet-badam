/*
 => Soruları metot kullanarak çözelim.

 Soru 1: Bir metoda parametre olarak gönderilen bir string ifade içerisindeki karakter sayısını ve 
         kelime sayısını bulan ve bu verileri dışarıya aktaran metodu yazınız.
*/

void KarakterSayisiBul(string metin, out int karakterSayisi, out int kelimeSayisi)
{
    karakterSayisi = metin.Length;
    kelimeSayisi = metin.Trim(' ', '.').Split(' ').Length;
}

int karakterSayisi;
int kelimeSayisi;
KarakterSayisiBul("Lisan-ı Osmanî’nin Edebiyatı Hakkında Mülâhazatı Şâmildir .", out karakterSayisi, out kelimeSayisi);

Console.WriteLine("Karakter sayısı: " + karakterSayisi);
Console.WriteLine("Kelime sayısı: " + kelimeSayisi);