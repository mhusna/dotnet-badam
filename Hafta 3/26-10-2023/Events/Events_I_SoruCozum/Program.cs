/*
 Soru: (NFS) Araba sınıfı oluşturup tekerleklerin patlamasını simüle eden kodu oop ile yazın.
 */

using Events_I_SoruCozum;

Araba araba = new Araba();

araba.LastikPatladi += Araba_LastikPatladi;

void Araba_LastikPatladi(object sender)
{
    Console.WriteLine("***********************");
    Console.WriteLine(sender+" konumundaki lastik patladı..");
}

while (araba.Sur())
{
    Thread.Sleep(25);
    Console.WriteLine("cis tak cis tak..");
}