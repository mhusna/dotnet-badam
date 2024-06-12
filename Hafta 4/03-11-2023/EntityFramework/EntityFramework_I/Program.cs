using EntityFramework_I.Data;
using EntityFramework_I.Models;

Console.WriteLine();

PersonelContext context = new PersonelContext();

/*
    BOLUM EKLEME 

context.Bolumler.Add( new Bolum() { BolumAdi = "Muhasebe"});
context.Bolumler.Add( new Bolum() { BolumAdi = "Satis"});
context.SaveChanges();
*/

/*
    PROJE EKLEME

context.Projeler.Add(new Proje { ProjeAdi = "Kızıl Elma" });
context.Projeler.Add(new Proje { ProjeAdi = "Anka" });
context.SaveChanges();
*/

/*
 
    PERSONEL EKLEME
 
Proje proje = context.Projeler.Find(1);
Personel personel = new Personel()
{
    Ad = "Cevdet",
    Soyad = "Korkmaz",
    BolumID = 1,
    Proje = proje
};

context.Personeller.Add(personel);
context.SaveChanges();
*/

/*
 Soru: Olmayan yeni bir bölüme personel veya proje ataması yapmak istersek ?


// Unit of Work Pattern
// Normalde her işlemden sonra context.savechanges yapmak gerekiyor
// Ama ef, unit of work patterni desteklediği için en sonda yaparsak olur.

// YONTEM 1

Proje proje = context.Projeler.Find(2);
Bolum bolum = new Bolum { BolumAdi = "IK" };
// İlla bu satıra gerek yok. Zaten aşağıda new personelde bölümü verdiğimiz için oluşturur.
// context.Bolumler.Add(bolum);
context.Personeller.Add(
    new Personel { Ad = "Selami", Soyad = "Dursun", Bolum = bolum, BolumID = bolum.BolumID, Proje = proje});

context.SaveChanges();

 */

// YONTEM 2

Proje proje = context.Projeler.Find(2);

context.Personeller.Add(
    new Personel { 
        Ad = "Selami",
        Soyad = "Dursun",
        Bolum = new Bolum { BolumAdi = "Halkla İlişkiler"},
        Proje = proje });

context.SaveChanges();