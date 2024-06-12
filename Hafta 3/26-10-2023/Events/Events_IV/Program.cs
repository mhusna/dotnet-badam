/*
    Soru: Belirli sayıda ürün kapasitesi olan bir depo nesnesi tanımlayıp, depo dolduğunda tetiklenen ve kullanıcıyı
    uyaran kodu oop yöntemlerine göre yazın.

    Depo'ya ürün ekleme, listeleme ve çıkarma işlemleri olmalı.
    Ürün: Id, Ad, Fiyat, Kategori
 */

using Events_IV;

Depo depo = new Depo();

Urun urun1 = new Urun { UrunID = 1, Ad = "Bulgur", Fiyat = 49.9, Kategori = "Bakliyat" };
Urun urun2 = new Urun { UrunID = 2, Ad = "Tavuk", Fiyat = 49.9, Kategori = "Şarküteri" };

List<Urun> urunler = new List<Urun>() { urun1, urun2};

depo.UrunEkle(urunler);

Console.WriteLine("*************");
foreach (Urun urun in depo.TumUrunler())
{
    Console.WriteLine(urun);
}

depo.UrunCikar(urun1);

Console.WriteLine("*************");
foreach (Urun urun in depo.TumUrunler())
{
    Console.WriteLine(urun);
}