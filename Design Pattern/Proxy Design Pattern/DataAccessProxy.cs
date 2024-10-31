namespace Proxy_Design_Pattern;
// Step 3: Implement the Proxy


public class DataAccessProxy : IDataAccess
{
    private RealDataAccess _realDataAccess;

    public string GetData()
    {
        // Lazy initialization: create RealDataAccess only when needed
        if (_realDataAccess == null)
        {
            Console.WriteLine("DataAccessProxy: Instantiating RealDataAccess on demand.");
            _realDataAccess = new RealDataAccess();
        }

        return _realDataAccess.GetData();
    }
}
