/*
 * int sayi = int.Parse(Console.ReadLine()); 
 * Console.WriteLine(sayi);
 * 
 * => YONTEM 1
 * 
 * int sayi;
 * if(int.TryParse(Console.ReadLine(), out sayi))
 *      Console.WriteLine(sayi); 
 *      
 * else
 *      Console.WriteLine("Girilen değer tamsayıya çevrilemez.");
 *      
 *      
 * => YONTEM 2: Sonradan gelen yenilik.
 * if(int.TryParse(Console.Readline(), out int sayi))
 *      Console.WriteLine(sayi);
 * 
 * else
 *      Console.WriteLine("Girilen değer tamsayıya çevrilemez...");
*/

// Aşağıdaki metodun içerisindeki a ve b parametrelerinin değerini metodun dışına return kullanmadan
// aktarabilir miyiz?

// YONTEM 1
void MetodA(ref int a, ref int b)
{
    a = 111;
    b = 222;
}

int c = 0, d = 0;
// KURAL(ref): Ref kullanılacaksa mutlaka initialize edilmeli.
MetodA(ref c, ref d);
Console.WriteLine(c+" "+d);


// YONTEM 2
void MetodB(out int a, out int b)
{
    a = 111;
    b = 222;
}

int e, f;
// KURAL(out): İlk değer ataması yapmaya gerek yoktur..
// Sonradan gelen yenilik ile out olan yerde tanımlamada yapılabilir.
MetodB(out e, out f);
Console.WriteLine(e+" "+f);

