/*
 Bir okul için öğrenci ve eğitmen bilgilerinin ve notlarının (tek not) tutulduğu bir uygulama geliştirilecektir.

 Uygulama rapor olarak;
    => Bir dersi alan öğrencilerin listesi
    => Eğitmen listesi
    => Öğrencilerin aldığı dersler (x no'lu öğrencinin)
    => Eğitmenin verdiği dersler (x no'lu eğitmenin)
    => Transcript (x no'lu öğrencinin)

 Sadece tek dönem olarak düşünün.
 Kaç tablo olmalı, isimleri ?
 Entity framework üzerinde;
    => Modelleri
    => Context sınfını
    => Navigation Property'lerini
  oluşturunuz.

 Veri girişi yapabilirsiniz.

 Verilen notlar 100'lük sisteme göre verilecektir. Fakat istenirse A, B, C, D, E, F şeklinde notlara
 dönüştürülebilmelidir..
 */

Console.WriteLine();

void Yazdir<T>(params T[] degerler)
{
    foreach (var item in degerler)
        Console.WriteLine(item);
}