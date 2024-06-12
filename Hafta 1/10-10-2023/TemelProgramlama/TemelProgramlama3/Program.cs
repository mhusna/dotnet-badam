//Soru: Kullanıcının girdiği sayının karesini alan kodu yazınız.



Console.Write("Karesi alınacak sayı: ");

// Yontem 1
//int number = Convert.ToInt32(Console.ReadLine());

// Yontem 2
int number = Int32.Parse(Console.ReadLine());

// String concanetion yontemi..
Console.WriteLine(number +" ^ 2: " +(number*number));

// Content placeholder yontemi..
Console.WriteLine("{0} ^ 2: {1}", number, (number * number));

// String Interpolation
Console.WriteLine($"{number} ^ 2: {number*number}");

