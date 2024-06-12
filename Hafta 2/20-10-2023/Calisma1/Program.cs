using Calisma1;
Yagis secilenYagisTipi = YagisManager.RastgeleYagisTipi();
List<Yagis> yagislar = new List<Yagis>();

for (int i = 0; i < 1000; i++)
{
    yagislar.Add(YagisManager.YagisOlustur(secilenYagisTipi));
    YagisManager.YagisYazdir(yagislar);
    Thread.Sleep(150);
    YagisManager.YagisKaydir(yagislar);
    YagisManager.RastgeleRuzgarOlustur(yagislar);
    YagisManager.YagisYazdir(yagislar);
}