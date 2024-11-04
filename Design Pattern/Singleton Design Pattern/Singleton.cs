namespace Singleton_Design_Pattern;

public class Singleton
{
    private int _index;
    private static readonly Object LockObject = new Object();
    private static volatile Singleton _instance;
    
    private Singleton()
    {
        _index = 0;
    }
    private Singleton(int index)
    {
        this._index = index;
    }
    
    // Using Synchronized To Lazy Initialization
    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            lock (LockObject)
            {
                if (_instance == null)
                {
                    var random = new Random();
                    _instance = new Singleton(random.Next(1, 100));
                }
            }
        }
        return _instance;
    }
    
    public static Singleton GetInstanceWithProblem()
    {
        var random = new Random();
        return new Singleton(random.Next(1, 100));
    }
    
    public void SaysHi()
    {
        Console.WriteLine($"Hi from thread {_index}");
    }
}