/*
 Soru: Kitap verilerinin tutulduğu liste üzerinde çalışan aşağıdaki raporları metot yazarak geliştiriniz.

    => 1- ID'ye göre kitap
    => 2- Fiyata göre kitaplar
    => 3- Kategoriye göre kitaplar
 */

using Delegates_IV_Tekrar;
using System;

List<Kitap> kitaplar = new List<Kitap>()
{
    new Kitap(){KitapID = 101, KitapAdi = "Denemeler", Fiyat = 99, Kategori = "Deneme"},
    new Kitap(){KitapID = 105, KitapAdi = "Buyuk Umutlar", Fiyat = 78, Kategori = "Roman"},
    new Kitap(){KitapID = 106, KitapAdi = "Cehennem", Fiyat = 123, Kategori = "Roman"},
    new Kitap(){KitapID = 125, KitapAdi = "İngilizce-Turkçe Sözlük", Fiyat = 99, Kategori = "Sözlük"}
};

List<Kitap> Getir(Predicate<Kitap> predicate)
{
    return kitaplar.FindAll(predicate);
}

void Yazdir(List<Kitap> kitaplar)
{
    foreach (Kitap kitap in kitaplar)
        Console.WriteLine(kitap);
}

Console.WriteLine("ID'ye göre kitap");
Yazdir(Getir(kitap => kitap.KitapID == 105));

Console.WriteLine("\n\nFiyata göre kitaplar");
Yazdir(Getir(kitap => kitap.Fiyat == 99));

Console.WriteLine("\n\nKategoriye göre kitaplar");
Yazdir(Getir(kitap => kitap.Kategori == "Roman"));