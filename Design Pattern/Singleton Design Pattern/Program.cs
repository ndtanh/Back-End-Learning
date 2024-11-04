using Singleton_Design_Pattern;

Console.WriteLine("Using Singleton Design Pattern With Problem");
var thread3 = new Thread(() => Singleton.GetInstanceWithProblem().SaysHi());
var thread4 = new Thread(() => Singleton.GetInstanceWithProblem().SaysHi());

Console.WriteLine("Using Singleton Design Pattern With Lazy Initialization");
var thread1 = new Thread(() => Singleton.GetInstance().SaysHi());
var thread2 = new Thread(() => Singleton.GetInstance().SaysHi());

thread1.Start();
thread2.Start();
thread3.Start();
thread4.Start();