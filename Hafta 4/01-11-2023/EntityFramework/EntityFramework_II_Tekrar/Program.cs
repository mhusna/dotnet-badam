using EntityFramework_II_Tekrar;

UrunContext urunContext = new UrunContext();

#region Örnek 1: Ürünleri A-Z'ye Doğru Sırala

#region Like Sql Yöntemi

Console.WriteLine("--- Örnek 1 - Yöntem 1: Like Sql --- ");
var result = from urun in urunContext.Urunler
             orderby urun.Fiyat ascending
             select urun;
Yazdir(result);

#endregion

#region Expression Tree Yöntemi

Console.WriteLine("--- Örnek 1 - Yöntem 2: Expression Tree Yöntemi --- ");

result = urunContext.Urunler.OrderBy(urun => urun.Fiyat);
Yazdir(result);

#endregion

#endregion

#region Örnek 2: Ürünleri Z-A'ya Doğru Sırala

#region Yöntem 1: Like Sql Yöntemi
Console.WriteLine("--- Örnek 2 - Like Sql Yöntemi");
result = from urun in urunContext.Urunler
         orderby urun.Fiyat descending
         select urun;

Yazdir(result);

#endregion

#region Yöntem 2: Expression Tree

Console.WriteLine("--- Örnek 2 - Expression Tree Yöntemi");
result = urunContext.Urunler.OrderByDescending(urun => urun.Fiyat);
Yazdir(result);

#endregion

#endregion

#region Soru 1: Urun verisindeki ID değerleri yerine Kategori ismi gelsin. (JOIN)

#region Yöntem 1: Like Sql Yöntemi
Console.WriteLine("--- Soru 1 - Yöntem 1:  ---");
var result2 = from urun in urunContext.Urunler
              join kategori in urunContext.Kategoriler
              on urun.KategoriID equals kategori.KategoriID
              select new { urun.UrunID, urun.UrunAdi, urun.Fiyat, kategori.KategoriAdi };
Yazdir(result2);
#endregion

#region Yöntem 2: Expression Tree Yöntemi

Console.WriteLine("--- Soru 1 - Yöntem 2");
result2 = urunContext.Urunler.Join(
                                    urunContext.Kategoriler,
                                    urun => urun.KategoriID,
                                    kategori => kategori.KategoriID,
                                    (urun, kategori) => new { urun.UrunID, urun.UrunAdi, urun.Fiyat, kategori.KategoriAdi }
                                   );
Yazdir(result2);
#endregion

#endregion

#region Soru 2: Kategorisi "Kırtasiye" olan ürünler gelsin. (JOIN)

#region Yöntem 1: Like Sql Yöntemi
Console.WriteLine("--- Soru 2 - Like Sql ---");
var result3 = from urun in urunContext.Urunler
          join kategori in urunContext.Kategoriler
          on urun.KategoriID equals kategori.KategoriID
          where kategori.KategoriAdi == "Hediyelik"
          select new {urun.UrunID, urun.UrunAdi, urun.Fiyat, kategori.KategoriID};
Yazdir(result3);
#endregion

#endregion


#region Yazdir<T>(IEnumerable<T> liste)
void Yazdir<T>(IEnumerable<T> liste)
{
    foreach (T item in liste)
        Console.WriteLine(item);
    Console.WriteLine();
}
#endregion