using OOP_I_Hoca;

Ferrari ferrari = new Ferrari();
Bmw bmw = new Bmw();
Bmx bmx = new Bmx();

Utility.EkranaYaz(ferrari);
Utility.EkranaYaz(bmw);
Utility.EkranaYaz(bmx);

Console.WriteLine("***********");

Boyahane boyahane = new Boyahane();
boyahane.Boya(ferrari, Utility.GetRandomColor());
boyahane.Boya(bmw, Utility.GetRandomColor());
//boyahane.Boya(bmx, Utility.GetRandomColor());

Utility.EkranaYaz(ferrari);
Utility.EkranaYaz(bmw);
Utility.EkranaYaz(bmx);