using Delegates_I;

Temsilci temsilci = delegate ()
{
    Console.WriteLine("Anonim Metod");
};

temsilci += delegate ()
{
    Console.WriteLine("Anonim Metod2");
};

temsilci();