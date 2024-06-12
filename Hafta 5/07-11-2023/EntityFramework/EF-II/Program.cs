using EF_II.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine();

ModelContext modelContext = new ModelContext();

//var urunler = modelContext.Urunlers;

//// Guncelle
//var urun = urunler.Find(102);
//urun.UrunAdi = "------";

// Silme - İlk başta açık yap bunu.
//urunler.Remove(urunler.Find(103));

// Ekleme
//var yeniUrun = new Urunler { UrunId = 123, UrunAdi = "Bisiklet", Fiyat = 3450, KategoriId = 13 };
//modelContext.Urunlers.Add(yeniUrun);

//Console.WriteLine("yeniUrun State => " + modelContext.Entry(yeniUrun).State.ToString());

// Değişiklikleri veri tabanına yansıt. Bunu ilk başta kapatarak çalıştır.
modelContext.SaveChanges();

void Listele<T>(List<T> values)
{
	Console.WriteLine();
	foreach (T value in values)
		Console.WriteLine(value +"\t"+ modelContext.Entry(value).State.ToString());
	Console.WriteLine();
}

//Listele(modelContext.Urunlers.ToList());
Listele(modelContext.Kategorilers.ToList());

Console.WriteLine("-------------------------");

// AsNoTracking oluduğu için bisiklet adı güncellenmeyecek.
var liste = modelContext.Urunlers.AsNoTracking();
var bisiklet = liste.FirstOrDefault(x => x.UrunId == 123);
bisiklet.UrunAdi = "Bmx Bisiklet";
modelContext.Entry(bisiklet).State = EntityState.Modified;
modelContext.SaveChanges();

foreach (var item in liste)
	Console.WriteLine(item + " " + modelContext.Entry(item).State.ToString());