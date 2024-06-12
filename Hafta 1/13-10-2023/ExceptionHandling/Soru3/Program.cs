/*
    Soru: Rastgele oluşturulmuş 20 değer arasında aynı değer varsa ekranda zemin rengi kırmızı olacak
          şekilde yazınız. Sayı aralığı: 1-100.



int[] GenerateRandomNumbers()
{
    int[] randomNumbers = new int[20];
    
    for (int i = 0; i < randomNumbers.Length; i++)
    {
        int number = new Random().Next(1, 101);
        //if(randomNumbers.Contains(number))
        //{
        //    Console.BackgroundColor = ConsoleColor.Red;
        //    Console.Write(number+" ");
        //}
        //else
        //{
        //    Console.BackgroundColor = ConsoleColor.Black;
        //    Console.Write(number+" ");
        //}
        randomNumbers[i] = number;
        //Console.BackgroundColor = ConsoleColor.Black;

    }

    return randomNumbers;
}

void EkranaYaz()
{
    int[] randomNumbers = GenerateRandomNumbers();

    for (int i = 0; i < randomNumbers.Length; i++)
    {
        int counter = 0;
        for (int j = 0; j < randomNumbers.Length; j++)
        {
            if (randomNumbers[i] == randomNumbers[j])
            {
                counter++;
                if (counter == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                }
            }
        }
    }

    foreach (var item in randomNumbers)
    {
        Console.Write(item + " ");
    }
    Console.BackgroundColor = ConsoleColor.Black;
}



for (int i = 0; i < 1000; i++)
{
    EkranaYaz();
    Console.WriteLine();
}
 */

int[] DiziOlustur(int adet)
{
    int[] sayilar = new int[adet];
    for (int i = 0; i < adet; i++)
        sayilar[i] = new Random().Next(1, 101);
    return sayilar;
}

bool DiziyiKontrolEt(int[] dizi)
{
    for (int i = 0; i < dizi.Length; i++)
    {
        for (int j = i + 1; j < dizi.Length; j++)
        {
            if (dizi[i] == dizi[j])
                return true;
        }
    }

    return false;
}

void Yazdir(int[] sayilar, bool ayniMi)
{
    if(ayniMi)
        Console.BackgroundColor = ConsoleColor.Red;
    else
        Console.BackgroundColor = ConsoleColor.Red;

    foreach (var item in sayilar)
        Console.Write(sayilar + " ");
    Console.WriteLine();
}

for (int i = 0; i < 5; i++)
{
    int[] sayilar = DiziOlustur(20);
    Yazdir(sayilar, DiziyiKontrolEt(sayilar));
}