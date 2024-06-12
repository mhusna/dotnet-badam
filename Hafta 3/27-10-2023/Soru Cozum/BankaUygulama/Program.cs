using Managers.Concrete;
using Model.Abstract;
using Model.Concrete;
using Model.Enums;

List<Personel> personeller = new List<Personel>()
{
    new Personel(){ Ad = "Ahmet", Soyad = "Gezdiler", Durum = PersonelDurum.Musait, Maas = 10_000 },
    new Personel(){ Ad = "Sakine", Soyad = "Tutsay", Durum = PersonelDurum.Mesgul, Maas = 9_000 }
};

List<Vezne> vezneler = new List<Vezne>()
{
    new Vezne(){ No = "A", Durum = VezneDurum.Musait, Musteri = null, Personel = personeller[0]},
    new Vezne(){ No = "B", Durum = VezneDurum.Kapali, Musteri = null, Personel = personeller[1]}
};

List<Musteri> musteriler = new List<Musteri>()
{
    new Musteri(){ Ad = "Celal", Soyad = "Kanzi"},
    new Musteri(){ Ad = "Safiye", Soyad = "Sansar"}
};

Banka banka = new Banka();

foreach (var item in musteriler)
    banka.MusteriManager.Ekle(item);

foreach (var item in vezneler)
    banka.VezneManager.Ekle(item);

foreach (var item in musteriler)
    new MusteriManager().BankayaGit(item);

while (true)
{
    if (!banka.IslemYap())
        break;
}