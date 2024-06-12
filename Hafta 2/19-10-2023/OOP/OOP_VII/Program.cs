using OOP_VII;
using System.Collections;

Random random = new Random();

ArrayList nesneler = new ArrayList();
for (int i = 0; i < 10; i++)
{
    int randomNumber = random.Next(1,3);
    if (randomNumber == 1)
        nesneler.Add(new Bardak());
    else
        nesneler.Add(new Tomruk());
}

foreach (object obj in nesneler)
    Console.WriteLine(obj);

Console.WriteLine("--------");

foreach (object obj in nesneler)
{
	if(obj is IKirilabilir)
		Console.WriteLine(obj);

	//if(item.GetType() != typeof(Tomruk))
	//	Console.WriteLine(item);

	//try
	//{
	//	IKirilabilir nesne = (IKirilabilir)item;
	//	Console.WriteLine(nesne);
	//}
	//catch (Exception e)
	//{
	//}
}