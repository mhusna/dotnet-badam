/* 
   MULTITHREAD PROGRAMLAMA

void Islem1()
{
	for (int i = 0; i < 1000; i++)
	{
		Console.WriteLine(i);
		Thread.Sleep(100);
	}
}

void Islem2()
{
    for (int i = 0; i < 1000; i++)
    {
        Console.WriteLine("AAA");
        Thread.Sleep(100);
    }
}

// Önce işlem 1, sonra işlem 2 çalışır.
//Islem1();
//Islem2();

ThreadStart ts1 = new ThreadStart(Islem1);
ThreadStart ts2 = new ThreadStart(Islem2);

Thread t1 = new Thread(ts1);
Thread t2 = new Thread(ts2);

t1.Priority = ThreadPriority.Highest;
t2.Priority = ThreadPriority.Lowest;

t1.Start();
t2.Start();
 */

/* ASENKRON PROGRAMLAMA */
using System.Diagnostics;

async Task Process1()
{
    await Task.Delay(10000);
    Console.WriteLine("Process 1 finished.");
    //return Task.CompletedTask;
}

async Task Process2()
{
    await Task.Delay(5000);
    Console.WriteLine("Process 2 finished.");
    //Task.CompletedTask;
}

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

// Çalışıyor ama, yine senkron çalıştı. Çalışması 15sn sürdü.
//await Process1();
//await Process2();

// Burada asenkron çalıştı ve 10 sn sürdü çalışması.
Task.WaitAll(Process1(), Process2());
stopwatch.Stop();

Console.WriteLine(stopwatch.ElapsedMilliseconds);