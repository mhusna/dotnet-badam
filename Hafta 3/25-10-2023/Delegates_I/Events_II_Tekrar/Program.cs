/*
    Soru: NFS'de araba giderken lastiği patlıyor. Bu olayı event ile yazın.
 */

using Events_II_Tekrar;

Araba araba = new Araba();
araba.LastikPatlamaOlayi += Araba_LastikPatlamaOlayi;

void Araba_LastikPatlamaOlayi(Lastik lastik)
{
    Console.WriteLine("##########################");
    Console.WriteLine($"\nArabanın {lastik.Konum} konumundaki lastiği patladı..");
    Console.WriteLine($"Güncel kilometre: {araba.Km}");
}

araba.Sur();