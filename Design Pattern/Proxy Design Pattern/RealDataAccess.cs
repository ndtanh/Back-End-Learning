namespace Proxy_Design_Pattern;

// Step 2: Implement the Real Subject

public class RealDataAccess : IDataAccess
{
    public RealDataAccess()
    {
        // Simulating a heavy initialization or resource-intensive operation
        Console.WriteLine("Initializing RealDataAccess (connecting to the database)...");
    }

    public string GetData()
    {
        // Simulating data fetching from the database
        return "Data from the database";
    }
}
