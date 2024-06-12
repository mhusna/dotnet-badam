/*
 
    ORNEK 1

Console.WriteLine("Diğer islemler");
int[] sayilar = { 43, 4566, 67, 33 };
Console.WriteLine("1. islem");
Console.WriteLine("2. islem");
Console.WriteLine("3. islem");


try
{
    Console.WriteLine(sayilar[10]);
}
catch
{
    Console.WriteLine("Hata");
}
*/


int[] sayilar = { 43, 4566, 67, 33 }; 
int a, b = 6, c = 2;
try
{
    a = b / c;
    Console.WriteLine(sayilar[10]);
    Console.WriteLine(a);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Database Log: "+ex.Message);
}
catch(IndexOutOfRangeException ex)
{
    Console.WriteLine("Database Log: " + ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine("Database Log: " + ex.Message);
}