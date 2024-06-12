/*
 Soru: Suyun kaynamasını simüle eden ısıtıcı nesnesini OOP'ye göre modelleyiniz ve çalıştırınız.

 3 event: Kabarcıklanma, ses çıkarma, kaynama. Suyun sıcaklığına göre tetiklenmesi lazım.
 Suyun sıcaklığını da counterla yap.
    40: Kabarcıklanma
    70: Ses Çıkarma
    100: Kaynama
 */

using Events_Soru;

Isitici isitici = new Isitici();
isitici.Kaynama += Isitici_Kaynama;
isitici.Kabarciklanma += Isitici_Kabarciklanma;
isitici.SesCikarma += Isitici_SesCikarma;

void Isitici_SesCikarma()
{
    Console.WriteLine("Ses çıkıyor..");
}

void Isitici_Kabarciklanma()
{ 
    Console.WriteLine("Kabarcıklar oluşuyor..");
}

void Isitici_Kaynama()
{
    Console.WriteLine("Kaynıyor.");
}

isitici.Kaynat();


// Hoca
Isitici isitici2 = new Isitici();
isitici2.Kabarciklanma += Isitici_Kabarciklanma1;
isitici2.SesCikarma += Isitici2_SesCikarma;
isitici2.Kaynama += Isitici2_Kaynama;

void Isitici2_Kaynama()
{
    Console.WriteLine(isitici.Derece + " fokur fokur.");
}

void Isitici2_SesCikarma()
{
    Console.WriteLine(isitici2.Derece + " s sss ss");
}

void Isitici_Kabarciklanma1()
{
    Console.WriteLine(isitici2.Derece + " o O o OO o");
}

isitici2.Isit();