using OOP_VI;

// Temsilciyi oluşturduk ve metot bağladık.
Temsilci temsilci = new Temsilci(Metodlar.Merhaba);

temsilci += Metodlar.Merhaba;
temsilci += Metodlar.Hi;
temsilci += Metodlar.Hola;
temsilci += Metodlar.Merhaba;


/*
    temsilci += Metodlar.Gunaydin;

    Temsilci bu metodu tasiyamaz. Neden ?
    => Return type aynı değil.
    
    ---------------------------------------

    temsilci += Metodlar.IyiGunler;
    
    Temsilci bu metodu taşıyamaz. Neden ?
    => İmzalar farklı.
 */
/*
// Temsilciye bağlı tüm metotları çalıştırır.
temsilci();

Console.WriteLine("*******************");

temsilci += temsilci;
temsilci();

Console.WriteLine("*******************");

temsilci -= Metodlar.Merhaba;
temsilci();

*/
foreach (Delegate @delegate in temsilci.GetInvocationList())
{
    //Console.WriteLine(@delegate.Method.Name);

    if (@delegate.Method.Name == "Hola")
        @delegate.DynamicInvoke();
}