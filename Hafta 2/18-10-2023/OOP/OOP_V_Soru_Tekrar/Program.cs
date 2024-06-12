/* 
    Soru: Bir satış firmasında çalışan personeller tam zamanlı ve yarı zamanlı olarak çalışmaktadırlar.
    
    Tam zamanlı personellerin maaşı (taban ücret + prim) şeklinde hesaplanmaktadır. Prim ise; 100.000 TL'ye
    kadar %1, 100.000 ile 250.000 arası %2, 250.000'den büyük ise %3 olarak hesaplanmaktadır.

    Yarı zamanlı personellerin maaşı ise ((çalıştığı saat * saat ücreti) + prim) şeklinde hesaplanmaktadır.
    Yarı zamanlı personellerin yaptığı satışın %1'i prim olarak maaşına yansıtılacaktır.

    Değişik tipte; en az 3 personel için bu maaşları hesaplayan ve gösteren uygulamayı yazınız.
    ** Bu uygulamayı OOP kullanarak yazınız.

    ÇIKTI

    1- Menü
    2- Personel verileri gir (Yarı zamanlı mı tam zamanlı mı sordur.)
    3- Listele
    4- Cikis
*/


using OOP_V_Soru_Tekrar;

int secim = 0;
do
{
    Console.WriteLine("*** MENU ***");
    Console.WriteLine("1- Personel Ekle");
    Console.WriteLine("2- Tüm Personeller");
    Console.WriteLine("3- Çıkış");
    Console.WriteLine();

    Console.Write("Seçim: ");
    secim = Convert.ToInt32(Console.ReadLine());

    switch (secim)
    {
        case 1:
            Console.Write("Personel Tipini Giriniz (tz veya yz): ");
            string sec = Console.ReadLine();

            if (sec == "tz")
            {
                FullTimeEmployee fullTime = new FullTimeEmployee();
                Console.Write("Personel Adı: ");
                fullTime.FirstName = Console.ReadLine();

                Console.Write("Personel Soyadı: ");
                fullTime.LastName = Console.ReadLine();

                Console.Write("Personel Taban Ücreti: ");
                fullTime.NormalSalary = double.Parse(Console.ReadLine());

                Console.Write("Personel Satış Adeti: ");
                fullTime.SellCount = int.Parse(Console.ReadLine());

                EmployeeManager.InsertEmployee(fullTime);
            }
            else if (sec == "yz")
            {
                PartTimeEmployee partTime = new PartTimeEmployee();
                Console.Write("Personel Adı: ");
                partTime.FirstName = Console.ReadLine();

                Console.Write("Personel Soyadı: ");
                partTime.LastName = Console.ReadLine();

                Console.Write("Personel Çalıştığı Saat: ");
                partTime.WorkHour = int.Parse(Console.ReadLine());

                Console.Write("Personel Saat Ücreti: ");
                partTime.PerHourSalary = double.Parse(Console.ReadLine());

                Console.Write("Personel Satış Adeti: ");
                partTime.SellCount = int.Parse(Console.ReadLine());

                EmployeeManager.InsertEmployee(partTime);
            }
            Console.WriteLine();
            break;

        case 2:
            foreach (Employee employee in EmployeeManager.ListEmployees())
                Console.WriteLine(employee.GetInfo());
            break;

        case 3:
            Console.WriteLine("Program sonlandırıldı. Bay bay...");
            break;

        default:
            Console.WriteLine("1 veya 2 numaralı seçeneklerden birini seçiniz...");
            Console.WriteLine();
            break;
    }


} while (secim != 3);