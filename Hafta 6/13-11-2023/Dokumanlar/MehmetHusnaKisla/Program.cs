using MehmetHusnaKisla.Data.Manager;
using MehmetHusnaKisla.Models;
using MehmetHusnaKisla.Utilities;

ManagerBLL manager = new ManagerBLL();

//Admin? admin = null;
//do
//{
//    Console.Clear();
//    Console.Write("Enter the first name: ");
//    string fname = Console.ReadLine();

//    Console.Write("Enter the password: ");
//    string password = Console.ReadLine();

//    admin = manager.AdminManager.GetByFNameAndPassword(fname, password);

//    if (admin == null)
//    {
//        Console.WriteLine("\nYanlış kullanıcı adı ve/veya şifre girişi yaptınız.");
//        Console.WriteLine("Devam etmek için 'Enter' tuşlayınız..");
//        Console.ReadLine();
//    }
//} while (admin == null);

int choice = 0;
do
{
    ConsoleUtility.DisplayMainMenu();
    choice = ConsoleUtility.GetChoice();

    switch (choice)
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break; 
        case 5:
            break;
        case 6:
            break;
        default:
            break;
    }

} while (choice != -1);