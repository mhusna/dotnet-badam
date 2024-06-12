using Delegates_II;

int Bes()
{
    return 5;
}

int On()
{
    return 10;
}

int Yirmi()
{
    return 20;
}

Temsilci temsilci = new Temsilci(Bes);
temsilci += On;
temsilci += Yirmi;
temsilci += On;

Console.WriteLine(temsilci());