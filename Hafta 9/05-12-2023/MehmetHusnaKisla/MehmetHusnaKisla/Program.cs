using MehmetHusnaKisla.Data.Manager;
using MehmetHusnaKisla.Enums;
using MehmetHusnaKisla.Models;
using MehmetHusnaKisla.Utilities;
using System.Security.Cryptography.X509Certificates;
using System.ServiceProcess;

Console.WriteLine();
ManagerBLL manager = new ManagerBLL();

// Aşağıdaki do-while döngüsü Kullanıcı adını ve şifresini alarak giriş yapmayı kontrol eder.
Admin? admin = null;
do
{
    Console.Clear();
    Console.Write("Admin Kullanıcı Adı: ");
    string userName = Console.ReadLine();

    Console.Write("Admin Şifresi: ");
    string password = Console.ReadLine();
    password = AdminUtility.sha256_hash(password);

    admin = manager.AdminManager.GetByUserNameAndPassword(userName, password);

    if (admin == null)
    {
        Console.WriteLine("\nYanlış kullanıcı adı ve/veya şifre girişi yaptınız.");
        Console.WriteLine("Devam etmek için 'Enter' tuşlayınız..");
        Console.ReadLine();
    }
} while (admin == null);

Artist? artist;
Album? album;
int choice = 0;
int id = 0;
do
{
    // Ana menüyü yazdırma ve seçim alma.
    ConsoleUtility.DisplayMainMenu();
    choice = ConsoleUtility.GetChoice();

    switch (choice)
    {
        // Admin işlemleri.
        case 1:
            AdminUtility.DisplayAdminMenu();
            choice = ConsoleUtility.GetChoice();

            switch (choice)
            {
                case 1:
                    admin = new Admin();
                    bool control = false;

                    // Kullanıcı adı kontrolü
                    do
                    {

                        Console.Write("Kullanıcı Adı Girin: ");
                        admin.UserName = Console.ReadLine();

                        control = manager.AdminManager.UserNameControl(admin.UserName);
                        if (!control)
                        {
                            Console.WriteLine("Bu kullanıcı adı zaten kullanımda !");
                            Console.WriteLine("Devam Etmek İçin 'Enter' Tuşlayınız.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    } while (!control);

                    // Admin şifre kontrolü
                    do
                    {
                        Console.Write("Admin şifresi: ");
                        admin.Password = Console.ReadLine();

                        Console.Write("Admin şifresi tekrar: ");
                        admin.PasswordConfirm = Console.ReadLine();


                        if (admin.Password.Count() < 8)
                        {
                            control = false;
                            Console.WriteLine("Şifre 8 haneden uzun olmalı !");
                            Console.WriteLine("Devam Etmek İçin 'Enter' Tuşlayınız.");
                            Console.ReadLine();

                        }
                        else
                        {
                            if (admin.Password == admin.PasswordConfirm)
                                break;
                            else
                            {
                                control = false;
                                Console.WriteLine("Şifreler uyuşmuyor !");
                                Console.WriteLine("Devam Etmek İçin 'Enter' Tuşlayınız.");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("Kullanıcı Adı Girin: " + admin.UserName);

                            }
                        }

                    } while (control == false);

                    // Yukarıdaki işlemler doğrulandığında şifreleme işlemi gerçekleşir 
                    // ve admin kayıt edilir.

                    admin.Password = AdminUtility.sha256_hash(admin.Password);
                    admin.PasswordConfirm = admin.Password;

                    manager.AdminManager.Add(admin);

                    break;
            }
            break;

        // Sanatçı İşlemleri
        case 2:
            ConsoleUtility.DisplaySubMenu("Sanatçı");
            choice = ConsoleUtility.GetChoice();

            switch (choice)
            {
                case 1:

                    // Sanatçı sorgulama.

                    id = ConsoleUtility.GetID();
                    artist = manager.ArtistManager.GetEntityByID(id);

                    if (artist == null)
                        Console.WriteLine("Böyle bir sanatçı bulunmamaktadır.");

                    else
                        ArtistUtility.DisplayArtist("Sanatçı", artist);

                    Console.WriteLine("\nDevam etmek için 'Enter' tuşlayınız..");
                    Console.ReadLine();
                    break;
                case 2:

                    // Ekrandan sanatçıya ait bilgileri alır ve ekleme işlemi yapar.

                    artist = ArtistUtility.GetInformation(new Artist());
                    manager.ArtistManager.Add(artist);

                    Console.WriteLine("\nİşlem gerçekleştirildi.");
                    Console.WriteLine("Devam etmek için 'Enter' tuşlayınız..");
                    Console.ReadLine();

                    break;

                case 3:

                    // Önce Sanatçıların listesini ekrana yazdırır.
                    // Daha sonra kullanıcıdan güncellenecek sanatçının id değerini alır
                    // Sonra da bilgilerini alır ve güncelleme işlemi gerçekleştirir.

                    ArtistUtility.DisplayArtist("Sanatçı Listesi", manager.ArtistManager.GetAllEntities().ToArray());
                    Console.WriteLine();
                    artist = manager.ArtistManager.GetEntityByID(ConsoleUtility.GetID());

                    artist = ArtistUtility.GetInformation(artist);
                    manager.ArtistManager.Update(artist);

                    Console.WriteLine("\nİşlem gerçekleştirildi.");
                    Console.WriteLine("Devam etmek için 'Enter' tuşlayınız..");
                    Console.ReadLine();

                    break;
                case 4:

                    // Önce sanatçı listesini yazdırır sonra da silinecek sanatçı id'sini alır.
                    // Ve siler.

                    ArtistUtility.DisplayArtist("Sanatçı Listesi", manager.ArtistManager.GetAllEntities().ToArray());
                    Console.WriteLine();

                    manager.ArtistManager.Delete(ConsoleUtility.GetID());
                    Console.WriteLine("\nİşlem gerçekleştirildi.");
                    Console.WriteLine("Devam etmek için 'Enter' tuşlayınız..");
                    Console.ReadLine();

                    break;
                case 5:
                    
                    // Sanatçıların listesini yazdırır.

                    ArtistUtility.DisplayArtist("Sanatçı Listesi", manager.ArtistManager.GetAllEntities().ToArray());

                    Console.WriteLine("\nDevam etmek için 'Enter' tuşlayınız..");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
            break;
        case 3:
            ConsoleUtility.DisplaySubMenu("Albüm");
            choice = ConsoleUtility.GetChoice();

            switch (choice)
            {
                // Albüm arama işlemi yapar. Albümü sanatçısıyla birlikte getirir.
                case 1:
                    id = ConsoleUtility.GetID();
                    album = manager.AlbumManager.GetAlbumWithArtist(id);

                    if (album == null)
                        Console.WriteLine("Böyle bir albüm bulunmamaktadır.");

                    else
                        AlbumUtility.DisplayAlbum("Albüm", album);

                    Console.WriteLine("\nDevam etmek için 'Enter' tuşlayınız..");
                    Console.ReadLine();
                    break;
                case 2:

                    // Sanatçıları yazdırır, daha sonra albüm bilgisini alır ve ekler.

                    ArtistUtility.DisplayArtist("Sanatçı Listesi", manager.ArtistManager.GetAllEntities().ToArray());

                    album = AlbumUtility.GetInformation(new Album());
                    manager.AlbumManager.Add(album);

                    Console.WriteLine("\nİşlem gerçekleştirildi.");
                    Console.WriteLine("Devam etmek için 'Enter' tuşlayınız..");
                    Console.ReadLine();

                    break;

                case 3:

                    // Albüm listesini yazdırır, güncellemek için bilgileri alır ve günceller.

                    AlbumUtility.DisplayAlbum("Albüm Listesi", manager.AlbumManager.GetAlbumsWithArtist().ToArray());
                    Console.WriteLine();
                    album = manager.AlbumManager.GetEntityByID(ConsoleUtility.GetID());

                    album = AlbumUtility.GetInformation(album);
                    manager.AlbumManager.Update(album);

                    Console.WriteLine("\nİşlem gerçekleştirildi.");
                    Console.WriteLine("Devam etmek için 'Enter' tuşlayınız..");
                    Console.ReadLine();

                    break;
                case 4:
                    
                    // Albümleri yazdırır, id alır ve siler.

                    AlbumUtility.DisplayAlbum("Albüm Listesi", manager.AlbumManager.GetAlbumsWithArtist().ToArray());
                    Console.WriteLine();

                    manager.AlbumManager.Delete(ConsoleUtility.GetID());
                    Console.WriteLine("\nİşlem gerçekleştirildi.");
                    Console.WriteLine("Devam etmek için 'Enter' tuşlayınız..");
                    Console.ReadLine();

                    break;
                case 5:

                    // Albümleri yazdırır.

                    AlbumUtility.DisplayAlbum("Albüm Listesi", manager.AlbumManager.GetAlbumsWithArtist().ToArray());

                    Console.WriteLine("\nDevam etmek için 'Enter' tuşlayınız..");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
            break;
        case 4:
            ReportUtility.DisplayReportMenu();
            choice = ConsoleUtility.GetChoice();

            switch (choice)
            {
                case 1:
                    // Tüm albümleri yazdırır.

                    ReportUtility.DisplayAllAlbumWithFilter("Albüm Listesi", null, manager.AlbumManager.GetAlbumsWithArtist().ToArray());

                    Console.WriteLine("\nDevam etmek için 'Enter' tuşlayınız..");
                    Console.ReadLine();
                    break;
                case 2:

                    // Satışı durmuş albümleri yazdırır.

                    ReportUtility.DisplayAllNotForSale("Satışı Durmuş Albümler", manager.AlbumManager.GetAlbumsWithArtist().ToArray());

                    Console.WriteLine("\nDevam etmek için 'Enter' tuşlayınız..");
                    Console.ReadLine();
                    break;
                case 3:

                    // Satışı devam eden albümleri yazdırır.

                    ReportUtility.DisplayAllForSale("Satışı Devam Eden Albümler", manager.AlbumManager.GetAlbumsWithArtist().ToArray());

                    Console.WriteLine("\nDevam etmek için 'Enter' tuşlayınız..");
                    Console.ReadLine();
                    break;
                case 4:

                    // En son eklenen 10 albümü yazdırır.

                    ReportUtility.DisplayLastAlbums("Sisteme En Son Eklenen 10 Albüm", 10, manager.AlbumManager.GetAlbumsWithArtist().ToArray());

                    Console.WriteLine("\nDevam etmek için 'Enter' tuşlayınız..");
                    Console.ReadLine();
                    break;
                case 5:

                    // İndirimdeki albümleri yazdırır.

                    ReportUtility.DiscountedAlbums("İndirimdeki Albümler (Z - A)", manager.AlbumManager.GetAlbumsWithArtist().ToArray());

                    Console.WriteLine("\nDevam etmek için 'Enter' tuşlayınız..");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
            break;
        default:
            break;
    }

} while (choice != -1);