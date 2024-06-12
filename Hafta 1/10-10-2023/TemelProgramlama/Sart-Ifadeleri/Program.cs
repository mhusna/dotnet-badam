/*
    Şart İfadeleri
        1) If-else
        2) Switch-case

    Goto kesinlikle kullanmamak gerekir, yapıyı çok karmaşık hale getirir.
 */

int secim = int.Parse(Console.ReadLine());

// Daha Performanslı !! if - if - if kullanmak yerine bu yapıyı kullan.
if(secim == 1)
    Console.WriteLine("Kredi karti..");
else if(secim == 2)
    Console.WriteLine("EFT");
else if(secim == 3)
    Console.WriteLine("PayPal");

// Bir uygulamada ne kadar çok if varsa o kadar çok yavaşlar.

if(5 == 5 && 4 == 4)
    Console.WriteLine("Doğru..");

char secenek = Convert.ToChar(Console.ReadLine());
if(secenek == 'e' || secenek == 'E')
    Console.WriteLine("Çıkış yapıldı.");