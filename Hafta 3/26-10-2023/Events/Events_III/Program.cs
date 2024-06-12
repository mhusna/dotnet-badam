using Events_III;

Araba araba = new Araba();
araba.HasarOlustu += Araba_HasarOlustu;

// Lastik yerine object sender yollamamız sadece lastikte hasar olmaması.
// Belki kaputta, motorda hasar olabilir.
void Araba_HasarOlustu(object sender)
{
    Console.WriteLine(((Lastik)sender).Konum);
}

int i = 0;
while (araba.Sur())
{
    Thread.Sleep(25);
    i++;
    Console.WriteLine(i+" km");
}