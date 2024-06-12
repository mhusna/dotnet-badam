using OOP_VI;

Nokta nokta1 = new Nokta(11, 22);
Console.WriteLine(nokta1.Point());

Nokta nokta2 = new Nokta(22, 55);
Console.WriteLine(nokta2.Point());

Nokta nokta3 = new Nokta();
Console.WriteLine(nokta3.Point());

ConsoleKeyInfo key = Console.ReadKey();
Console.WriteLine(key.Key);