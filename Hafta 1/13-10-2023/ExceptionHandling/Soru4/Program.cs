/*
    Soru: 100 öğrencinin 1-10 arası notlarının frekansını bulup, en yüksek frekansı olan 3 notu
          bulan metodu yazınız.


int[] GenerateNotes()
{
    int[] notes = new int[11];
    for (int i = 1; i < 101; i++)
    {
        int note = new Random().Next(1, 11);
        notes[note]++;
    }

    return notes;
}

int[] MaxFrek(int[] notes)
{
    Array.Sort(notes);
    Array.Reverse(notes);
    int[] maxNotes = { notes[0], notes[1], notes[2] };
    return maxNotes;
}

void EkranaYazdir(int[] notes)
{
    for (int i = 0; i < notes.Length; i++)
    {
        Console.Write(" "+notes[i]);
    }
    Console.WriteLine();
}

int[] notlar = GenerateNotes();
EkranaYazdir(notlar);

Console.WriteLine("*********");

int[] enYuksekNotlar = MaxFrek(notlar);
EkranaYazdir(enYuksekNotlar);
 */

int[] NotlariOlustur(int ogrenciSayisi)
{
    int[] notlar = new int[ogrenciSayisi];
    for (int i = 0; i < ogrenciSayisi; i++)
        notlar[i] = new Random().Next(1, 11);
    return notlar;
}

int[] FrekansHesapla(int[] notlar)
{
    int[] frekanslar = new int[11];
    for (int i = 0; i < notlar.Length; i++)
    {
        frekanslar[notlar[i]]++;
    }
    return frekanslar;
}

void DiziYazdir(int[] dizi)
{
    for (int i = 1; i < dizi.Length; i++)
        Console.WriteLine($"{i}: {dizi[i]}");
}

int[] data = NotlariOlustur(100);

int[] frekanslar = FrekansHesapla(data);
int[] ydkFrekanslar = new int[frekanslar.Length];
Array.Copy(frekanslar, ydkFrekanslar, frekanslar.Length);

DiziYazdir(frekanslar);

Array.Sort(frekanslar);
Array.Reverse(frekanslar);

Console.WriteLine("******************");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(frekanslar[i]+": "+ Array.IndexOf(ydkFrekanslar, frekanslar[i]));
}