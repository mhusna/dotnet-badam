using System.Collections;

ArrayList liste = new ArrayList();
liste.Add(10);
liste.Add(4);
liste.Add(7);
//liste.Add("sekiz");
    
int toplam = 0;
foreach (int sayi in liste)
{
    toplam += sayi;
}

Console.WriteLine(toplam);

List<int> liste2 = new List<int>();
liste2.Add(10);
liste2.Add(4);
liste2.Add(7);
//liste2.Add("sekiz");

toplam = 0;
foreach (int sayi in liste2)
{
    toplam += sayi;
}

Console.WriteLine(toplam);