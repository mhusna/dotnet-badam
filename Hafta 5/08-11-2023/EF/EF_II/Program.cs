/*
    ## EF Core'da Miras Kullanımı
        1- TPH: Table Per Hierarchy
            Dezavantajı: Normalizasyon yok.
            Avantajı: Join olmadığından hızlı.
        2- TPT: Table Per Type: EF Core 7.0.1'de daha sade kullanımı var.
        3- TPC: Table Per Concrete  !!EF Core > 7.0
 */

using EF_II.Data;
using EF_II.Models;

KisiContext context = new KisiContext();
context.Add(new Personel { Ad = "Antonio", Soyad = "Cavasala", Maas = 145_000 });
context.Add(new Musteri { Ad = "Lebron", Soyad = "James", Cari = -270_000 });
context.Add(new Musteri { Ad = "Lionel", Soyad = "Tevez", Cari = -345_000 });
context.SaveChanges();

foreach (var item in context.Musteriler)
{
    Console.WriteLine($"{item.ID} {item.Cari}");
}