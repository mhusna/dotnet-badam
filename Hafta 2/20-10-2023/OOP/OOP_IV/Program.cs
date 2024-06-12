/*
    Soru: Ekrana farklı renklerle merhaba yazınız. En az 10 renk.
 */

/*
    -- Kötü Yöntem --
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("mrb");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("mrb");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("mrb");
Console.ForegroundColor = ConsoleColor.White;
*/

for (int i = 0; i < 16; i++)
{
    Console.ForegroundColor = (ConsoleColor)i;
    Console.Write("mrb - ");
    Console.WriteLine((int)((ConsoleColor)i));
}

Console.WriteLine("******************************");

foreach (string name in Enum.GetNames(typeof(ConsoleColor)))
    Console.WriteLine(name);