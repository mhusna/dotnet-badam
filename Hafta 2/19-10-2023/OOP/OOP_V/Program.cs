using OOP_V;
using System.Collections;

void Yaz(ArrayList liste)
{
	foreach (object o in liste)
		Console.Write(o + " ");
	Console.WriteLine();
}

ArrayList arrayList1 = new ArrayList();
ArrayList arrayList2 = new ArrayList();
ArrayList arrayList3 = new ArrayList();

arrayList1.Add(34);
arrayList1.Add(15);
arrayList1.Add(22);

arrayList1.Sort();
Yaz(arrayList1);

arrayList2.Add("İstanbul");
arrayList2.Add("Ankara");
arrayList2.Add("Adana");

arrayList2.Sort();
Yaz(arrayList2);

arrayList3.Add(new Urun { UrunID = 111, UrunAdi = "Defter", Fiyat = 45 });
arrayList3.Add(new Urun { UrunID = 134, UrunAdi = "Pergel", Fiyat = 90 });
arrayList3.Add(new Urun { UrunID = 88, UrunAdi = "Açı Ölçer", Fiyat = 60 });

arrayList3.Sort();
Yaz(arrayList3);