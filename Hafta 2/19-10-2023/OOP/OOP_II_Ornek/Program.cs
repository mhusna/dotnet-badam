/*
    Soru: Daire, silindir, koni örneğini polymorphism kullanarak tekrar yazınız.
    
    Daire: Pi * r * r
    Silindir: (Pi * r * r) * h
    Hacim: (Pi * r * r * h) / 3
 */

using OOP_II_Ornek;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

Daire daire = new Daire() { r = 3 };
Daire silindir = new Silindir() { r = 3, H = 5 };
Daire koni = new Koni() { r = 3, H = 5 };

ArrayList liste = new ArrayList();
liste.Add(daire);
liste.Add(silindir);
liste.Add(koni);

foreach (Daire sekil in liste)
    Console.WriteLine(sekil.Hesapla());
