/*
    Soru: NFS'de araba giderken lastiği patlıyor.
 */

using Events_II;
using System;

Araba araba = new Araba();

araba.LastikPatlama += Araba_LastikPatlama;

void Araba_LastikPatlama(string lastikKonum)
{
    Console.WriteLine("Lastik Patladi: " + lastikKonum);
}

araba.Sur();