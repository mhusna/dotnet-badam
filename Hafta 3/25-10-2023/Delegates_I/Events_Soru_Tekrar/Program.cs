/*
 Soru: Suyun kaynamasını simüle eden ısıtıcı nesnesini OOP'ye göre modelleyiniz ve çalıştırınız.

 3 event: Kabarcıklanma, ses çıkarma, kaynama. Suyun sıcaklığına göre tetiklenmesi lazım.
 Suyun sıcaklığını da counterla yap.
    40: Kabarcıklanma
    70: Ses Çıkarma
    100: Kaynama
 */

using Events_Soru_Tekrar;

Kettle kettle = new Kettle();

kettle.Kabarciklanma += Kettle_Kabarciklanma;
kettle.SesCikarma += Kettle_SesCikarma;
kettle.Kaynama += Kettle_Kaynama;

void Kettle_Kaynama()
{
    Console.WriteLine("fkR fKR");
}

void Kettle_SesCikarma()
{
    Console.WriteLine("sS ssS");
}

void Kettle_Kabarciklanma()
{
    Console.WriteLine("oO ooO");
}

kettle.Kaynat();