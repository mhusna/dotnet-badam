using AbstractFactoryPattern.Concrete;

ModernFurnitureFactory modernFurnitureFactory = new ModernFurnitureFactory();
VintageFurnitureFactory vintageFurnitureFactory = new VintageFurnitureFactory();


FurnitureManager manager = new FurnitureManager(modernFurnitureFactory);
Console.WriteLine(manager.CreateTable());
Console.WriteLine(manager.CreateChair());

Console.WriteLine("------------------");

FurnitureManager manager2 = new FurnitureManager(vintageFurnitureFactory);
Console.WriteLine(manager2.CreateTable());
Console.WriteLine(manager2.CreateChair());