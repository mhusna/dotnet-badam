/*
 Soru: Kitap verilerinin tutulduğu liste üzerinde çalışan aşağıdaki raporları metot yazarak geliştiriniz.

    => 1- ID'ye göre kitap
    => 2- Fiyata göre kitaplar
    => 3- Kategoriye göre kitaplar
 */

using Delegates_IV;

List<Kitap> kitaplar = new List<Kitap>()
{
    new Kitap(){KitapID = 101, KitapAdi = "Denemeler", Fiyat = 99, Kategori = "Deneme"},
    new Kitap(){KitapID = 105, KitapAdi = "Buyuk Umutlar", Fiyat = 78, Kategori = "Roman"},
    new Kitap(){KitapID = 106, KitapAdi = "Cehennem", Fiyat = 123, Kategori = "Roman"},
    new Kitap(){KitapID = 125, KitapAdi = "İngilizce-Turkçe Sözlük", Fiyat = 99, Kategori = "Sözlük"}
};

void KitapGetir(int id)
{
    Console.WriteLine(kitaplar.Find(kitap => kitap.KitapID == id));
}

List<Kitap> FiyataGoreKitaplar(double fiyat)
{
    return kitaplar.FindAll(kitap => kitap.Fiyat == fiyat);
}

List<Kitap> KategoriyeGoreKitaplar(string kategori)
{
    return kitaplar.FindAll(kitap => kitap.Kategori == kategori);
}

void Yazdir(List<Kitap> kitaplar)
{
    foreach (Kitap kitap in kitaplar)
        Console.WriteLine(kitap);
}

KitapGetir(101);
Console.WriteLine("************");
Yazdir(FiyataGoreKitaplar(99));
Console.WriteLine("************");
Yazdir(KategoriyeGoreKitaplar("Roman"));