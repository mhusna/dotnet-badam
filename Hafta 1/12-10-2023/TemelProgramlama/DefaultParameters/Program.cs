/*
 * OPTIONAL PARAMETERS
 * 
 * Optional Parameters; NSA bir metodun kaç tane tanımlanmış argument'i var ise; metod kullanılırken o kadar
 * parametre gönderilmelidir..
 * 
 * Optional parametrelerde ise; bir argument'e varsayılan değeri tanımlanırken atanır, sonraki kullanımlarda
 * parametre gönderilmez ise tanımlı değer, gönderilirse gelen değer kullanılır.
 * 
 * NAMED PARAMETERS
 * 
 * NŞA; bir metod kullanılırken parametreler tanımlandığı sıra ile gönderilmelidir, named parametre kullanılırsa
 * tanımlandığı sıraya gerek olmadan isimleri ile birlikte istenilen sıradan gönderilir.
 * 
 * İki yapı da C# 4.0 sonrasında gelmiştir.
 */

// Default Parameters
void Islem(int a, int b, int c = 33)
{
    Console.WriteLine($"{a} {b} {c}");
}

Islem(11, 22, 33);
Islem(11, 22, 333);

// Named Parameters
Islem(b: 22, a: 11, c: 333);

/*
 * Özel durum: Eğer named parametreler tanımlandığı sırada gönderilirse c: yazmaya gerek yok, sıralı gönderilmez
 * ise yazmak gerekir.
 */

