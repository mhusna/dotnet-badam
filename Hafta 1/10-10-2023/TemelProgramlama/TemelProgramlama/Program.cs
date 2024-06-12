Console.WriteLine("Değişkenler...");

int sayi1 = 12;
int sayi2, sayi3;

/*
    ** İsimlendirme Kuralları **
    * int 11sayi; => olamaz
    * int en buyuk sayi => olamaz
    * 
    * Verilecek isim ile yapılacak iş uyumlu olmalı.
    *
    ** Notasyonlar **
    * 1) Camel Case => enBuyukSayi
    *       degiskenler, parametreler, form elemanlarinin isimlendirilmesinde kullanilir.
    *
    * 2) Pascal Case => EnBuyukSayi
    *       class, metot vb.. isimlendirmelerinde kullanilir.
    * 
    * 3) Macar Notasyonu => intEnBuyukSayi
    * 
    * 4) Kebab Case => en-buyuk-sayi
    *       Mvc Tag helper'larda kullanılır. 
    * 
    * 5) Snake Case => en_buyuk_sayi
 */

bool kontrol = true;
char karakter1 = 'a';
char karakter2 = 'A';
// char karakter3 = 'AA'; => Tanımlanamaz
// byte sayi = 300; => Boyutu gecti.