using EntityFramework_III.Data;
using Microsoft.EntityFrameworkCore;

OkulContext context = new OkulContext();
//foreach (var ogr in context.Ogrenciler)
//    Console.WriteLine(ogr);

var result = context.OgrenciDersler.Where(x => x.OgrenciID == 1);
foreach (var ders in result)
    Console.WriteLine(ders);

Console.WriteLine("**************");

// Include(): Eager loading
// İhtiyacı olan tabloya join cümlesini kendisi yazar.
var result2 = context.OgrenciDersler.Include("Ders").Where(x => x.Ogrenci.Ad == "Cevdet");

foreach (var ogr in result2)
    Console.WriteLine(ogr.Ders.DersAdi + " " + ogr.Ders.Kredi);