/*using System.Data.Common;

foreach (string item in DbProviderFactories.GetProviderInvariantNames())
{
    Console.WriteLine(item);
}

// Bu yöntem ile istenilen her veritabanına göre komut oluşturulur.
DbProviderFactory dbProvider = DbProviderFactories.GetFactory("");
dbProvider.CreateCommand();*/


using FactoryPattern;

Dosya dosya1 = FileManager.CreateFile("json");
Dosya dosya2 = FileManager.CreateFile("xml");

Console.WriteLine(dosya1);
Console.WriteLine(dosya2);