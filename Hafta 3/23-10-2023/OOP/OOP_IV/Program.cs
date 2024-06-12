//int id = null;

Nullable<int> sayi;
sayi = null;

Console.WriteLine(sayi.HasValue);
//Console.WriteLine(sayi.Value);

int? sayi2 = null;
sayi2.GetValueOrDefault();
Console.WriteLine(sayi2.GetValueOrDefault());
Console.WriteLine(sayi2);
Console.WriteLine(sayi2 ?? -1);
Console.WriteLine(sayi2);
sayi2 = sayi2 ?? -1;
Console.WriteLine(sayi2);