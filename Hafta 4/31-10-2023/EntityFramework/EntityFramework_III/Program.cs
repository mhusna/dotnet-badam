using EntityFramework_III;

#region LINQ to Objects
List<Kitap> kitaplar = new List<Kitap>()
{
    new Kitap(){ KitapID = 1234, KitapAdi = "Denemeler", Kategori = "Deneme", Fiyat = 90},
    new Kitap(){ KitapID = 1235, KitapAdi = "Da Vinci", Kategori = "Roman", Fiyat = 95},
    new Kitap(){ KitapID = 1236, KitapAdi = "Başlangıç", Kategori = "Roman", Fiyat = 110},
    new Kitap(){ KitapID = 1237, KitapAdi = "Empati", Kategori = "Roman", Fiyat = 90},
    new Kitap(){ KitapID = 1238, KitapAdi = "Avrupa Atlası", Kategori = "Atlas", Fiyat = 85},
};


// Soru: Fiyatları 90 olan kitapları bulunuz ?
#region LINQ Kullanmadan
foreach (Kitap kitap in kitaplar)
{
    if (kitap.Fiyat == 90)
        Console.WriteLine(kitap);
}
#endregion

#region Like SQL
var result = from kitap in kitaplar
             where kitap.Fiyat == 90
             select kitap;

Yazdir(result);
#endregion

#region Expression Tree
var result2 = kitaplar.Where(kitap => kitap.Fiyat == 90);
Yazdir(result2);
#endregion

#region Deffered LINQ Sorgusu
Console.WriteLine("*************");
int id = 1234;

var result3 = from kitap in kitaplar
              where kitap.KitapID == id
              select kitap;

id = 1237;
Yazdir(result3);
#endregion

#region Immediate LINQ Sorgusu
Console.WriteLine("*************");

id = 1234;
var result4 = (from kitap in kitaplar
              where kitap.KitapID == id
              select kitap).ToList();

id = 1237;
Yazdir(result4);
#endregion

#endregion
void Yazdir(IEnumerable<Kitap> kitaplar)
{
    foreach (var item in kitaplar)
        Console.WriteLine(item);
}