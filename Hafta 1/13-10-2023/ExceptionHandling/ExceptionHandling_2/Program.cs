using ExceptionHandling_2;

int sayi = Convert.ToInt32(Console.ReadLine());
try
{
    //throw new NotImplementedException();
    if (sayi == 5)
        throw new BesOlamazException();
}
catch(BesOlamazException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("İstisna olsa da olmasa da çalışır.");
}