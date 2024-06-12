using EF_IV.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("## Foreign Key Delete Behavior ##");

void Listele<T>(List<T> values)
{
    Console.WriteLine();
    foreach (T value in values)
        Console.WriteLine(value);
    Console.WriteLine();
}

ModelContext modelContext = new ModelContext();

//var kategori = modelContext.Kategorilers.Find(12);
//modelContext.Kategorilers.Remove(kategori);
//modelContext.SaveChanges();

//Console.WriteLine("## Ürünler ##");
//Listele(modelContext.Urunlers.AsNoTracking().ToList());

//Console.WriteLine("## Kategoriler ##");
//Listele(modelContext.Kategorilers.AsNoTracking().ToList());

/*
    ## Include() Kullanımı ##
    => Hata verir, navigation property'ler boş.
    => Join işlemi yapılmadı.

foreach (var item in modelContext.Urunlers.AsNoTracking().ToList())
    Console.WriteLine(item + $"{item.Kategori.KategoriAdi}");

    ## Include Kullanmadan Join İşlemi

var result = from urun in modelContext.Urunlers
             join kategori in modelContext.Kategorilers
             on urun.KategoriId equals kategori.KategoriId
             select new { urun.UrunId, urun.UrunAdi, urun.Fiyat, kategori.KategoriAdi };
foreach (var item in result.ToList())
    Console.WriteLine(item);

    ## Include Kullanımı

*/
Console.WriteLine("-------------");
foreach (var item in modelContext.Urunlers.Include("Kategori").ToList())
    Console.WriteLine($" {item} - {item.Kategori.KategoriAdi}");