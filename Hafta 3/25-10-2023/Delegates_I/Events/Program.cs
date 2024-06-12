using Events;

// 4. Adım
Buton buton = new Buton();

// 5. Adım
buton.Tikla += Buton_Tikla;
void Buton_Tikla()
{
    Console.WriteLine("Tiklandi"); ;
}

// 6. Adım
buton.Calistir();