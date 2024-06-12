using Delegates_IV_Hoca;
/*
 Soru: Kitap verilerinin tutulduğu liste üzerinde çalışan aşağıdaki raporları metot yazarak geliştiriniz.

    => 1- ID'ye göre kitap
    => 2- Fiyata göre kitaplar
    => 3- Kategoriye göre kitaplar
 */
List<Kitap> kitaplar = new List<Kitap>()
{
    new Kitap(){KitapID = 101, KitapAdi = "Denemeler", Fiyat = 99, Kategori = "Deneme"},
    new Kitap(){KitapID = 105, KitapAdi = "Buyuk Umutlar", Fiyat = 78, Kategori = "Roman"},
    new Kitap(){KitapID = 106, KitapAdi = "Cehennem", Fiyat = 123, Kategori = "Roman"},
    new Kitap(){KitapID = 125, KitapAdi = "İngilizce-Turkçe Sözlük", Fiyat = 99, Kategori = "Sözlük"}
};

List<Kitap> Ara(Predicate<Kitap> predicate)
{
    return kitaplar.FindAll(predicate);
}

void Yazdir(List<Kitap> kitaplar)
{
    foreach (Kitap kitap in kitaplar)
        Console.WriteLine(kitap);
}

Yazdir(Ara(kitap => kitap.KitapID == 101));
Console.WriteLine("************");
Yazdir(Ara(kitap => kitap.Fiyat == 99));
Console.WriteLine("************");
Yazdir(Ara(kitap => kitap.Kategori == "Roman"));