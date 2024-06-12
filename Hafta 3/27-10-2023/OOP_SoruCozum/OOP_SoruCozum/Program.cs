using Models;

void VerileriGoster<T>(List<T> items)
{
	Console.WriteLine();
	foreach (T item in items)
	{
		Console.WriteLine(item);
	}
}

Banka banka = new Banka();
VerileriGoster(banka.Musteriler.Listele());
VerileriGoster(banka.Personeller.Listele());
VerileriGoster(banka.Vezneler.Listele());

//banka.MusaitVeznelereMusteriAta();
Console.WriteLine("**************************");
VerileriGoster(banka.Vezneler.Listele());
VerileriGoster(banka.Musteriler.Listele());

banka.Vezneler.IslemYap();
Console.WriteLine("**************************");
VerileriGoster(banka.Vezneler.Listele());