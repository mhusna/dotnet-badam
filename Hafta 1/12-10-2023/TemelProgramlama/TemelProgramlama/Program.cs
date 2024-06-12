// Soru: 2 tamsayiyi, 3 tamsayiyi, 4 tamsayiyi toplayan metotları yazınız.
int Topla(int[] dizi)
{
    return dizi.Sum();
}

int[] dizi = {10, 20, 30};
int toplam = Topla(dizi);
Console.WriteLine($"Toplam: {toplam}");

/* Fonksiyon 2 */
int Topla2(params int[] dizi)
{
    return dizi.Sum();
}

int toplam2 = Topla2(10, 20, 30);
Console.WriteLine($"Toplam 2: {toplam2}");

/*
 * Params:
 * => Bir metodun aynı parametre tipinde birden fazla değer alması gerektiği durumlarda
 * birden fazla aynı isimde metot yazmak yerine; params kullanarak değişken sayıda aynı
 * tip parametre alan metotlar yazabiliriz.
 * 
 * Kurallar:
 * => Bir metotta sadece 1 params kullanılabilir.
 * => Bir metotta params kullanılacaksa en sonda olmalıdır.
 */