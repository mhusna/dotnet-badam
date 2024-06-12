using EF_I.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("--- EF Core Veri Yükleme Mekanizmaları ---");

ModelContext context = new ModelContext();

/*
    Hata verir. Çünkü Join olmadan kategori adına ulaşmaya çalışıyoruz. 
 
var result = context.Urunlers;
Console.WriteLine(result.ToQueryString());
foreach (var item in result)
    Console.WriteLine($"{item.UrunId} {item.UrunAdi} {item.Fiyat} {item.Kategori.KategoriAdi}");

OLUŞAN SQL SORGUSU
------------------
SELECT "u"."URUN_ID", "u"."FIYAT", "u"."KATEGORI_ID", "u"."URUN_ADI"
FROM "URUNDBHOCA"."URUNLER" "u"
*/

/*
    ## Eager Loading

var result = context.Urunlers.Include("Kategori");
Console.WriteLine(result.ToQueryString());
foreach (var item in result)
    Console.WriteLine($"{item.UrunId} {item.UrunAdi} {item.Fiyat} {item.Kategori.KategoriAdi}");

OLUŞAN SQL SORGUSU
------------------
SELECT "u"."URUN_ID", "u"."FIYAT", "u"."KATEGORI_ID", "u"."URUN_ADI", "k"."KATEGORI_ID", "k"."KATEGORI_ADI"
FROM "URUNDBHOCA"."URUNLER" "u"
LEFT JOIN "URUNDBHOCA"."KATEGORILER" "k" ON "u"."KATEGORI_ID" = "k"."KATEGORI_ID"

*/

/*
    ## Explicitly Loading
    
    Aşağıdaki komutlar çalıştığında, Kitap kategorisinin alt elemanları gelmez.
    
var kategori = context.Kategorilers.FirstOrDefault(x => x.KategoriAdi == "Kitap");
Console.WriteLine($"{kategori.KategoriId} {kategori.KategoriAdi} {kategori.Urunlers.Count()}");


    Aşağıdaki komutlar çalıştığında, alt elemanlar gelir. Many olanlar için Collection() metodu kullanılır.

var kategori = context.Kategorilers.FirstOrDefault(x => x.KategoriAdi == "Kitap");
context.Entry(kategori).Collection(x => x.Urunlers).Load();
Console.WriteLine($"{kategori.KategoriId} {kategori.KategoriAdi} {kategori.Urunlers.Count()}");

foreach (var item in kategori.Urunlers)
    Console.WriteLine($"{item.UrunId} - {item.UrunAdi} - {item.Fiyat}");

    Eğer ürün üzerinden kategori'ye gidilecekse bir ürünün bir kategorisi olduğu için Referance() kullanılır.

var tren = context.Urunlers.FirstOrDefault(x => x.UrunId == 100);
context.Entry(tren).Reference("Kategori").Load();

// Veya böyle de yazılabilir.
//context.Entry(tren).Reference(x => x.Kategori).Load();
Console.WriteLine($"{tren.UrunId} - {tren.UrunAdi} - {tren.Fiyat} - {tren.Kategori.KategoriAdi}");

 */

/*
    ## Lazy Loading
        1- Bunun için Microsoft.EntityFrameworkCore.Proxies indirilmeli.
        2- Navigation Property'ler virtual olarak işaretlenir.
        3- Context sınıfında OnConfiguring metoduna: optionsBuilder.UseLazyLoadingProxies(); komutunu ekle.
    Lazy loading olduğunda Include() yada Load() metodlarını kullanmadan ihtiyaç olduğunda doğrudan verileri
    getirir. Sürekli sorgu yazdığından kötü performans dolayısıyla tercih edilmemeli.

var result = context.Urunlers;
Console.WriteLine(result.ToQueryString());
foreach (var item in result)
    Console.WriteLine($"{item.UrunId} {item.UrunAdi} {item.Fiyat} {item.Kategori.KategoriAdi}");

 */

/*
    EF Core'da istenildiğinde SQL cümleleri yazılarak sorgular çalıştırılabilir.
 */

var result = context.Urunlers.FromSqlRaw("Select * From URUNLER");

foreach (var item in result)
    Console.WriteLine($"{item.UrunId} {item.UrunAdi}");