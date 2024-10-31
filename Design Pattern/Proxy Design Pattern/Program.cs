namespace Proxy_Design_Pattern;

class Program
{
    static void Main()
    {
        IDataAccess dataAccess = new DataAccessProxy();

        Console.WriteLine("Client: Requesting data for the first time.");
        Console.WriteLine(dataAccess.GetData()); // Initializes RealDataAccess and fetches data

        Console.WriteLine("\nClient: Requesting data again.");
        Console.WriteLine(dataAccess.GetData()); // Uses existing RealDataAccess instance
    }
}