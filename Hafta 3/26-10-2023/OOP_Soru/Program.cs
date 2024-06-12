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

using Models.Concrete;

List<Musteri> musteriler = new List<Musteri>()
{
     new Musteri() { MusteriID = 1, Ad = "Ahmet", IslemTipi = IslemTipi.Havale},
     new Musteri() { MusteriID = 2, Ad = "Deniz", IslemTipi = IslemTipi.ParaYatirma},
     new Musteri() { MusteriID = 3, Ad = "Selim", IslemTipi = IslemTipi.ParaCekme},
     new Musteri() { MusteriID = 4, Ad = "Serkan", IslemTipi = IslemTipi.ParaCekme}
};

Banka banka = new Banka();

foreach (Musteri musteri in musteriler)
    musteri.IslemYap(banka);