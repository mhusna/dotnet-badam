using OOP_V.Ornek1;
using OOP_V.Ornek2;
using OOP_V.Ornek3;

Hesapla<int> hesapla1 = new Hesapla<int>();
Hesapla<double> hesapla2 = new Hesapla<double>();
/*
    Hesapla<string> hesapla3 = new Hesapla<string>();

    Olamaz. Neden ?
    => T, değer tipli olmalı.
 */

Test<string> test1 = new Test<string>();
Test<object> test2 = new Test<object>();

/*
    Test<int> test3 = new Test<int>();
    
    Olamaz. Neden ?
    => T, referans tipli olmalı.
 */

PersonelIslemleri<GenelMudur> personelIslemleri1 = new PersonelIslemleri<GenelMudur>();
PersonelIslemleri<Hizmetli> personelIslemleri2 = new PersonelIslemleri<Hizmetli>();

/*
    PersonelIslemleri<GuvenlikGorevlisi> personelIslemleri3 = new PersonelIslemleri<GuvenlikGorevlisi>();    

    Olamaz. Neden ?
    => T, personel sınıfından türemiş olmalı.
 */

SilahIslemleri<GenelMudur> silahIslemleri1 = new SilahIslemleri<GenelMudur>();
SilahIslemleri<GuvenlikGorevlisi> silahIslemleri2 = new SilahIslemleri<GuvenlikGorevlisi>();
/*
    SilahIslemleri<Hizmetli> silahIslemleri2 = new SilahIslemleri<Hizmetli>();    
  
    Olamaz. Neden ?
    => T, ISilahTasiyabilir arayüzünden implement edilmiş olmalı.
 */

PersonelYonetimi<GenelMudur> personelYonetimi = new PersonelYonetimi<GenelMudur>();
PersonelYonetimi<Hizmetli> personelYonetimi2 = new PersonelYonetimi<Hizmetli>();

/*
    PersonelYonetimi<Ceo> personelYonetimi3 = new PersonelYonetimi<Ceo>();
    
    Olamaz. Neden ?
    => T, default ctor'a sahip olmalı.
 */
