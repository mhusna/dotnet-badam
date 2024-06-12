/*
    Soru: GTA garaj örneğinin kodunu yazınız.
 */

using OOP_I;

Araba[] arabalar = new Araba[3];
arabalar[0] = new Ferrari() { Brand = "Ferrari"};
arabalar[1] = new Bmx() { Brand = "Bmx"};
arabalar[2] = new Serce() { Brand = "Serce"};

Yazdir(arabalar);

Console.WriteLine();
Console.WriteLine("********************");
Console.WriteLine();

foreach (Araba araba in arabalar)
{
    try
    {
        Garaj.Boya((IBoyanabilir)araba);
    }
    catch
    {
        Console.WriteLine("Olmaaaaaaaaaz !");
    }
        
}

Yazdir(arabalar);


void Yazdir(Araba[] arabalar)
{
    foreach (Araba araba in arabalar)
        Console.WriteLine(araba.Brand + ": " +araba.Color);
}