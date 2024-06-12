Console.Write("Seçim: ");
int secim = int.Parse(Console.ReadLine());
switch (secim)
{
	case 1:
		Console.WriteLine("Bir");
		break;
    case 2:
        Console.WriteLine("İki");
        break;
    case 3:
    case 4:
        Console.WriteLine("Üç veya dört.");
        break;
    default:
        Console.WriteLine("1, 2, 3, 4 değil.");
		break;
}