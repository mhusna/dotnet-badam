//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//Console.WriteLine("ÖNCESİ");
//foreach (var item in numbers)
//{
//    Console.Write(item + " ");
//}

//Array.Resize(ref numbers, 15);

//Console.WriteLine("SONRASI");
//foreach (var item in numbers)
//{
//    Console.Write(item + " ");
//}

/*
// Soru: Rastgele oluşturulmuş 50 elemanlı bir dizi içerisindeki tek sayıları bulan ve
// donduren metodu yazınız. Sayı aralığı 1-100.


Random random = new Random();
int[] sayilar = new int[100];
string tekSayilar = "";

for (int i = 0; i < 50; i++)
{
	int number = random.Next(1, 101);
	if (number % 2 == 1)
		sayilar[number]++;
}

void Metot(int[] sayiDizisi)
{
    for (int i = 0; i < sayiDizisi.Length; i++)
	{
		if (sayiDizisi[i] != 0)
            tekSayilar += i.ToString() + " ";
	}
}

Metot(sayilar);
Console.WriteLine(tekSayilar);
*/

// Hocanın Çözümü

int[] GetRandomValues(int length)
{
	int[] array = new int[length];
	for(int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(1, 101);
	return array;
}

void DisplayValues(int[] numbers)
{
	foreach(int number in numbers)
		Console.Write(number +" ");
	Console.WriteLine();
}

int[] GetOddValues(int[] numbers)
{
	int[] oddNumbers = new int[0];
	int counter = 0;
	foreach (var number in numbers)
	{
		if(number % 2 == 1)
        {
			counter++;
            Array.Resize(ref oddNumbers, counter);
			oddNumbers[counter - 1] = number;
        }
	}
	return oddNumbers;
}

int[] numbers = GetRandomValues(50);
DisplayValues(numbers);

DisplayValues(GetOddValues(numbers));

DisplayValues(numbers.ToList().FindAll(x => x % 2 == 1).ToArray());