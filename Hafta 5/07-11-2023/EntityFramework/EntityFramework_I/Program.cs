/*
 Soru: ÜrünAdi, Fiyatı ve Kategori bilgilerini tutan bir Oracle veri tabanını entity framework core
       model first yöntemi ile geliştiriniz.

       => Bilgi Ekleme
       => Listeleme: ID'ye göre, tüm ürünler, kategori adına göre ürünler
       => Güncelleme
       => Silme

       işlemleri yapan uygulamayı konsol üzerinde yazınız.
 */

using EntityFramework_I.Managers;
using EntityFramework_I.Model;

/*

        KATEGORİLER EKLENDİ 

CategoryManager categoryManager = new CategoryManager();

Category[] categories = new Category[]
{
    new Category(){ CategoryID = 1, CategoryName = "Elektronik"},
    new Category(){ CategoryID = 2, CategoryName = "Mutfak"},
    new Category(){ CategoryID = 3, CategoryName = "Temizlik"}
};

categoryManager.Add(categories.ToArray());
*/

int secim = 0;
ProductManager productManager = new ProductManager();
CategoryManager categoryManager = new CategoryManager();
do
{
    Console.Clear();
    Console.WriteLine("1- Kategori Ekle");
    Console.WriteLine("2- Ürün Ekle");
    Console.WriteLine("3- Ürün Raporları");
    Console.WriteLine("4- Ürün Güncelle");
    Console.WriteLine("5- Ürün Sil");
    Console.WriteLine("=======================");
    Console.Write("Seciminiz: ");
    secim = int.Parse(Console.ReadLine());

    switch (secim)
    {
        case 1:
            Console.Clear();
            Console.Write("Kategori Adı: ");
            string kategoriAdi = Console.ReadLine();

            Category category = new Category() { CategoryName = kategoriAdi };
            categoryManager.Add(category);
            break;

        case 2:
            Console.Clear();

            Console.WriteLine("=== Kategoriler ===");
            foreach (Category entity in categoryManager.GetAll())
                Console.WriteLine(categoryManager.Display(entity));
            Console.WriteLine("====================\n");

            Console.Write("Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Ürün Fiyatı: ");
            double productPrice = double.Parse(Console.ReadLine());

            Console.Write("Kategori ID: ");
            int categoryId = int.Parse(Console.ReadLine());

            productManager = new ProductManager();
            Product product = new Product() 
            { 
                ProductName = productName,
                Price = productPrice,
                CategoryID = categoryId
            };

            productManager.Add(product);
            break;

        case 3:
            Console.Clear();
            Console.WriteLine("6- ID'ye Göre Ürün Getir");
            Console.WriteLine("7- Tüm Ürünleri Getir");
            Console.WriteLine("8- Kategori Adına Göre Ürünleri Getir");

            int raporSecim = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (raporSecim)
            {
                case 6:
                    Console.Write("Ürün ID: ");
                    int productIdToGet = int.Parse(Console.ReadLine());
                    Console.WriteLine(productManager.Display(productManager.Get(productIdToGet)));

                    Console.WriteLine("\nDevam etmek için Enter'a basın..");
                    Console.ReadLine();
                    break;

                case 7:
                    foreach (Product entity in productManager.GetAll())
                        Console.WriteLine(productManager.Display(entity));
                    Console.WriteLine("\nDevam etmek için Enter'a basın..");
                    Console.ReadLine();
                    break;

                case 8:
                    Console.WriteLine("=== Kategoriler ===");
                    foreach (Category entity in categoryManager.GetAll())
                        Console.WriteLine(categoryManager.Display(entity));
                    Console.WriteLine("====================\n");

                    Console.Write("Secim: ");
                    string categoryName = Console.ReadLine();

                    foreach (Product entity in productManager.GetAllByCategoryName(categoryName))
                        Console.WriteLine(productManager.Display(entity));

                    Console.WriteLine("\nDevam etmek için Enter'a basın..");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("YANLIŞ SEÇİM !!");
                    break;
            }
            break;

        case 4:
            Console.Clear();

            Console.WriteLine("=== Ürünler ===");
            foreach (Product entity in productManager.GetAll())
                Console.WriteLine(productManager.Display(entity));
            Console.WriteLine("====================\n");

            Console.Write("Güncellenecek Ürün ID'sini girin: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Ürün Ad: ");
            string productNameToUpdate = Console.ReadLine();

            Console.Write("Ürün Fiyat: ");
            double productPriceToUpdate = double.Parse(Console.ReadLine());

            Product productToUpdate = productManager.Get(productId);
            productToUpdate.ProductName = productNameToUpdate;
            productToUpdate.Price = productPriceToUpdate;

            productManager.Update(productToUpdate);
            break;

        case 5:
            Console.WriteLine("=== Ürünler ===");
            foreach (Product entity in productManager.GetAll())
                Console.WriteLine(productManager.Display(entity));
            Console.WriteLine("====================\n");

            Console.Write("Silinecek Ürün ID'sini girin: ");
            int productIdToDelete = int.Parse(Console.ReadLine());

            ProductManager productManager2 = new ProductManager();
            productManager2.Delete(productManager2.Get(productIdToDelete));
            break;

        default:
            Console.WriteLine("Program sonlandı..");
            break;
    }

} while (secim != -1);