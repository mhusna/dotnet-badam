/*
    Soru: Liste içerisindeki çift sayıları bulunuz.
 */

using System;

List<int> sayilar = new List<int>() { 34, 45, 6, 7, 88, 33, 145, 777 };

// Yontem 1
Console.WriteLine("Yontem 1");
foreach (int sayi in sayilar)
{
    if(sayi % 2 == 0)
        Console.Write(sayi+ " ");
}

// Yontem 2
Console.WriteLine("\n\nYontem 2");
bool CiftSayilar(int sayi)
{
    return sayi % 2 == 0; 
}

Predicate<int> predicate = new Predicate<int>(CiftSayilar);

foreach (int sayi in sayilar.FindAll(predicate))
    Console.Write(sayi + " ");

/*
    
    YONTEM 2 vol. 2
    
Console.WriteLine("\n\nDouble Ornek");

List<double> sayilar2 = new List<double>() { 14.0, 12.5, 3.6, 7.7, 15.1};
bool TekSayilar(double sayi)
{
    return sayi % 2 != 0;
}

Predicate<double> predicate2 = new Predicate<double>(TekSayilar);
foreach (double sayi in sayilar2.FindAll(predicate2))
{
    Console.Write(sayi + " ");
}
*/


// Yontem 3
Console.WriteLine("\n\nYontem 3");
foreach (int sayi in sayilar.FindAll(CiftSayilar))
    Console.Write(sayi+" ");

// Yontem 4
Console.WriteLine("\n\nYontem 4");
foreach (int sayi in sayilar.FindAll(delegate (int sayi) { return sayi % 2 == 0; }))
{
    Console.Write(sayi + " ");
}


// Yontem 5
Console.WriteLine("\n\nYontem 5");
foreach (int sayi in sayilar.FindAll(sayi => sayi % 2 == 0))
{
    Console.Write(sayi + " ");
}