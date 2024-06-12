using SingletonPattern;

Test test1 = new Test();
Test test2 = new Test();

Console.WriteLine(test1.GetHashCode());
Console.WriteLine(test2.GetHashCode());

Console.WriteLine("------------------");

SingletonPattern.Single single1 = SingletonPattern.Single.GetSingle();
SingletonPattern.Single single2 = SingletonPattern.Single.GetSingle();

Console.WriteLine($"Single 1: {single1.GetHashCode()}");
Console.WriteLine($"Single 2: {single2.GetHashCode()}");