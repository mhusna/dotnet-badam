using Soru18;

Bus bus = new Bus(30);

for (int i = 0; i < bus.koltukSayisi; i++)
{
    Console.WriteLine(i+" - "+bus.Seats[i]);
}