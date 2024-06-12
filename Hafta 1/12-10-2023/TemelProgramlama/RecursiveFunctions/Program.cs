/*
 * Recursive Functions
 * => Kendi kendini çağıran metodlar.
 */

int Faktoriyel(int sayi)
{
    if (sayi == 1)
        return 1;
    
    return sayi * Faktoriyel(sayi - 1);
}

Console.WriteLine(Faktoriyel(5));