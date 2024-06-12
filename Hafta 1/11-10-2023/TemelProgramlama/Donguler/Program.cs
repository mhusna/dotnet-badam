/*
    Donguler
    => For
    => While
    => Do - While
        => Önce işlem, sonra şart. En az 1 kere çalışır.
    => Foreach
        => Iteration variable'ın sadece get metodu var. 
        => Sadece koleksiyonlar üzerinde çalışır.
        => IEnumerable arayüzünü uygulamış olan sınıflar üzerinde çalışır.

    Döngüler Karakteristik Olarak İkiye Ayrılırlar
        1) Sonu Belli Olan: For
        2) Sonu Belli Olmayan: While, Do-While
 
 */

for(int i = 0 ; i < 10; i++)
{
    Console.WriteLine(i);
}

// Sonsuz döngü
for(; ; )
{
    Console.WriteLine("Yaz");
}

int sayac = 0;
while (sayac < 10)
{
    Console.WriteLine(sayac);
    sayac++;
}

// Sonsuz döngü
while(true)
{
    Console.WriteLine("Yaz");
}

int say = 0;
do
{
    Console.Write($"Say: {say}");
    say++;
}while(say < 10);