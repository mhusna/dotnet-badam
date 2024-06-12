using Microsoft.Win32.SafeHandles;

internal class Program
{
    static void Islem(int sayi)
    {
        sayi = 999;
    }

    static void Islem(int[] sayilar)
    {
        for (int i = 0; i < sayilar.Length; i++)
            sayilar[i] = 999;
    }

    static void DiziYaz(int[] sayilar)
    {
        foreach (var item in sayilar)
            Console.Write(item+" ");
        Console.WriteLine();
    }

    private static void Main(string[] args)
    {
        int number = 111;
        Console.WriteLine("Metodu çağırmadan önce: " + number);
        Islem(number);
        Console.WriteLine("Metodu çağırdıktan sonra: "+ number);

        int[] numbers = { 1, 2, 3, 4, 5, 6 };

        Console.WriteLine("Metodu çağırmadan önce: ");
        DiziYaz(numbers);
        Islem(numbers);

        Console.WriteLine("Metodu çağırdıktan sonra: ");
        DiziYaz(numbers);
    }
}