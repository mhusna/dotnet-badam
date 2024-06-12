using OOP_I;

Araba araba = new Araba();
Ferrari ferrari = new Ferrari();
Serce serce = new Serce();

araba.Sur();
ferrari.Sur();
serce.Sur();

Console.WriteLine("***************");

Araba araba2 = new Araba();
Araba ferrari2 = new Ferrari();
Araba serce2 = new Serce();

araba2.Sur();
ferrari2.Sur();
serce2.Sur();

// Polymorphism örnek.
Console.WriteLine(serce);
Console.WriteLine(ferrari);

Object