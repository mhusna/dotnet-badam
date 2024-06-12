/*
    SORU 

    a) Bir market için; çeşitli ürünlerin tutulduğu stok yönetimiyle alakalı bir uygulama geliştirilecektir.
    
        => Stokta tutulacak ürünler:
            1- Bulgur
            2- Kağıt Havlu
            3- Yumurta
            4- Şişe Süt
            5- Yoğurt
            6- Bardak

        => Raporlar
            1- Tüm Ürünler
            2- Bozuk Ürünler
            3- Kırık Ürünler
            4- Zamanı Geçmiş Ürünler

    b) Markette çalışan personellerin verilerini tutan kısımı da yazınız.

        => Personel çeşitleri:
            1- Tam Zamanlı : TabanMaas
            2- Yarı Zamanlı : Calisma Saati x Saatlik Ucret
    
        => Raporlar
            1- Tüm Personeller
            2- Yarı Zamanlı Personeller
            3- Tam Zamanlı Personeller
    
 */

using SoruCozum;
using SoruCozum.Models;


Market market = new Market();

market.StockManagement.Add(new Bulgur() { ProductID = 1, ProductName = "Bulgur", Price = 40, IsRuined = false, SKT = new DateTime(2025, 10, 12), Tett = new DateTime(2024, 12, 12) });
market.StockManagement.Add(new Bulgur() { ProductID = 2, ProductName = "Bulgur", Price = 40, IsRuined = true, SKT = new DateTime(2025, 10, 12), Tett = new DateTime(2024, 12, 12) });

//Utility<Product>.Print(market.StockManagement.GetAll());
Utility<Product>.Print(market.StockManagement.RuinedProducts().ToList());

market.PersonelManagement.Add(new TamZamanliPersonel() { PersonelID = 1, Name = "Mehmet Husna", SurName = "Kisla", TabanMaas = 2000 });
Utility<Personel>.Print(market.PersonelManagement.TamZamanliPersoneller().ToList());