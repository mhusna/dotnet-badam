string strMesaj = "deneme 123 emened";
Console.WriteLine(strMesaj.ToUpper());
Console.WriteLine(strMesaj.ToLower());

string strPath1 = "C:\\dosyalar\\data\\json.data";
string strPath2 = "C:/dosyalar/data/json.data";
string strPath3 = @"C:\dosyalar\data\json.data";

// En uzun yöntem
string DosyaAdi(string path)
{
	return path.Substring(path.LastIndexOf("\\") + 1);
}

string DosyaAd(string path)
{
    int index = path.LastIndexOf('/');
	string dosyaAdi = "";
	for (int i = index+1; i < path.Length; i++)
	{
		dosyaAdi += path[i];
	}

	return dosyaAdi;
}

string DosyaAd2(string path)
{
	string[] words = path.Split('/');
	Console.WriteLine(words[words.Length - 1]);

	return words[words.Length - 1];
}

Console.WriteLine(DosyaAd(strPath2));
Console.WriteLine(DosyaAd2(strPath2));
Console.WriteLine(Path.GetFileName(strPath2));