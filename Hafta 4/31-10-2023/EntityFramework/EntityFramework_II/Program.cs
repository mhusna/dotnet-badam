using EntityFramework_II;

#region Extension Methods
int number = 5;
Console.WriteLine("Kare Al: " + number.KareAl());
Console.WriteLine("Kup Al: " + number.KupAl());
Console.WriteLine("Ikiye Böl: " + number.IkiyeBol());
Console.WriteLine("Istenen Sayiya Böl: " + number.IstenenSayiyaBol(5));

string ifade = "Ahmet";
Console.WriteLine(ifade.Cevir());
#endregion

#region Expression Tree
number = 8;
Console.WriteLine(number.IstenenSayiyaBol(4).KareAl().KupAl().IkiyeBol());
#endregion

