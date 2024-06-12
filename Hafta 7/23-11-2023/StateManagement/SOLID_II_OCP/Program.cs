using SOLID_II_OCP.Cozum_I_Interface;

DosyaManager dosyaManager = new DosyaManager();

JSON json = new JSON();
XML xml = new XML();
CSV csv = new CSV();

Console.WriteLine(dosyaManager.Oku(json, "dosya yolu"));
Console.WriteLine(dosyaManager.Oku(xml, "dosya yolu"));
Console.WriteLine(dosyaManager.Oku(csv, "dosya yolu"));

TXT txt = new TXT();
Console.WriteLine(dosyaManager.Oku(txt, "dosya yolu"));