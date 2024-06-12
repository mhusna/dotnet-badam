using EntityFramework_II;

#region LINQ Sorguları

UrunContext urunContext = new UrunContext();

#region Urunleri Fiyatına Göre Sırala.. (A-Z)

// Bu şekilde kullanımda hata var.
// urunContext.Urunler.Sort();

#region LIKE SQL Yöntemi

var result = from urun in urunContext.Urunler
             orderby urun.Fiyat ascending
             select urun;

Yazdir(result);

#endregion

var ressult = from urun in urunContext.Urunler
              orderby urun.Fiyat ascending
              select urun;
Console.WriteLine("###############################");
Yazdir(ressult);
Console.WriteLine("###############################");


#region Expression Tree Yöntemi

var result2 = urunContext.Urunler.OrderBy(urun => urun.Fiyat);
Yazdir(result2);

#endregion

Console.WriteLine("````````````````````````````````");
var ressult2 = urunContext.Urunler.OrderBy(urun => urun.Fiyat);
Yazdir(ressult2);
Console.WriteLine("````````````````````````````````");


#endregion

#region Urunleri Fiyatına Göre Sırala (Z-A)

#region Like SQL Yöntemi

var result3 = from urun in urunContext.Urunler
              orderby urun.Fiyat descending
              select urun;

Yazdir(result3);

#endregion

#region Expression Tree Yöntemi

var result4 = urunContext.Urunler.OrderByDescending(urun => urun.Fiyat);
Yazdir(result4);

#endregion

#region IComparable arayüzü ile

Console.WriteLine("************************");
urunContext.Urunler.Sort();

Yazdir(urunContext.Urunler);

#endregion

#endregion

#region Soru 1

/*
 Urunler verisindeki ID değerleri yerine Kategori isimleri gelsin.. (Join)
 */

#region Like SQL

Console.WriteLine("--- Soru 1: Like SQL ---\n");
var result5 = from urun in urunContext.Urunler
              join kategori in urunContext.Kategoriler
              on urun.KategoriID equals kategori.KategoriID
              select new { urun.UrunID, urun.UrunAdi, urun.Fiyat, kategori.KategoriAdi };

//var result5 = from urun in urunContext.Urunler
//              join kategori in urunContext.Kategoriler on urun.KategoriID equals kategori.KategoriID
//              select new
//              {
//                  UrunID = urun.UrunID,
//                  UrunAdi = urun.UrunAdi,
//                  Fiyat = urun.Fiyat,
//                  KategoriAdi = kategori.KategoriAdi
//              };


Yazdir(result5);
#endregion

#region Expression Tree

Console.WriteLine("--- Soru 2: Expression Tree ---\n");
var result6 = urunContext.Urunler.Join(
    urunContext.Kategoriler,
    urun => urun.KategoriID,
    kategori => kategori.KategoriID,
    (urun, kategori) => new { urun.UrunID, urun.UrunAdi, urun.Fiyat, kategori.KategoriAdi }
    );

Yazdir(result6);
#endregion

#endregion

#region Soru 2

/*
 Kategorisi Kırtasiye olan ürünler.. (join)
 */

#region Like SQL Yöntemi
Console.WriteLine("--- Soru 2: Like SQL ---\n");
var result7 = from urun in urunContext.Urunler
              join kategori in urunContext.Kategoriler
              on urun.KategoriID equals kategori.KategoriID
              where kategori.KategoriAdi == "Hediyelik"
              select new { urun.UrunID, urun.UrunAdi, urun.Fiyat, kategori.KategoriAdi };
Yazdir(result7);

#endregion

#region Expression Tree Yöntemi
Console.WriteLine("--- Soru 2: Expression Tree ---\n");
var result8 = urunContext.Urunler.Join(
    urunContext.Kategoriler.Where(kategori => kategori.KategoriAdi == "Kirtasiye"),
    urun => urun.KategoriID,
    kategori => kategori.KategoriID,
    (urun, kategori) => new { urun.UrunID, urun.UrunAdi, urun.Fiyat, kategori.KategoriAdi }
    );

Yazdir(result8);
#endregion


#endregion

#region Soru 3

/*
 En pahalı 3 ürün.
 */

#region Like SQL
var result9 = (from urun in urunContext.Urunler
               orderby urun.Fiyat descending
               select urun).Take(3);
Yazdir(result9);
#endregion

#region Expression Tree
var result10 = urunContext.Urunler.OrderByDescending(urun => urun.Fiyat).Take(3);
Yazdir(result10);
#endregion


#endregion

#endregion

#region Ortak Fonksiyon
void Yazdir<T>(IEnumerable<T> liste)
{
    foreach (T item in liste)
        Console.WriteLine(item);
    Console.WriteLine();
}
#endregion