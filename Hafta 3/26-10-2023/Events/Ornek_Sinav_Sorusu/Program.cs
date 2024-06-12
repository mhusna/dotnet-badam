/*
    Bir bankada müşteriler sırayla işlemlerini yapmaktadırlar. 
    Müşterilere hizmet veren bankolar vardır (2 - 3). -- TAMAM
    Müşteriler 3 farklı işlem yapabilmektedirler ve her işlemin ayrı bir süresi olacaktır. -- TAMAM
    Rastgele her müşteri bir işlem ile gelecektir. -- TAMAM
    Veznedeki çalışanların durumu boş yada dolu olabilir. -- TAMAM
    Boş olduğunda yeni müşteri vezneye gitmeli. 
    Vezneye gittiğinde vezne durumu meşgul olacak. -- TAMAM

    Bu sistemi gerçekleştirecek sınıfları tasarlayınız.
    Havale => 5dk.
    Para Çekme => 7dk.
    Para Yatırma => 2dk.
 */

using Models;

List<Personel> personeller = new List<Personel>()
{
    new Personel(){ PersonelID = 1, Ad = "Ahmet", Soyad = "Okuyan", Durum = true},
    new Personel(){ PersonelID = 2, Ad = "Mehmet", Soyad = "Karlı", Durum = true},
    new Personel(){ PersonelID = 3, Ad = "Yeşim", Soyad = "Sal", Durum = true}
};

List<Banko> bankolar = new List<Banko>()
{
    new Banko(){ BankoNo = 1, Durum = true, Personel = personeller[0]},
    new Banko(){ BankoNo = 2, Durum = true, Personel = personeller[1]},
    new Banko(){ BankoNo = 3, Durum = true, Personel = personeller[2]}
};

List<Hesap> hesaplar = new List<Hesap>()
{
    new Hesap(){ HesapNo = "1", Bakiye = 15000},
    new Hesap(){ HesapNo = "2", Bakiye = 5000},
    new Hesap(){ HesapNo = "3", Bakiye = 7500}
};

List<Musteri> musteriler = new List<Musteri>()
{
    new Musteri(){ MusteriID = 1, Ad = "Ayşe", Soyad = "Dürüst", Hesap = hesaplar[0]},
    new Musteri(){ MusteriID = 2, Ad = "Deniz", Soyad = "Katar", Hesap = hesaplar[1]},
    new Musteri(){ MusteriID = 3, Ad = "Safiye", Soyad = "Reklamcı", Hesap = hesaplar[2]}
};

Banka banka = new Banka()
{
    Bankolar = bankolar,
    Personeller = personeller
};

List<Islem> islemler = new List<Islem>
{
    new Havale(),
    new ParaYatirma(),
    new ParaCekme()
};

musteriler[0].Islem = islemler[new Random().Next(0, 3)];
musteriler[0].IslemYap(banka);

musteriler[1].Islem = islemler[new Random().Next(0, 3)];
musteriler[1].IslemYap(banka);