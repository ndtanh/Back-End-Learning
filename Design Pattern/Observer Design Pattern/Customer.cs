namespace ConsoleApp1;

//Step 4: Implement Concrete Observers
public class Customer : IObserver
{
    private string _name;

    public Customer(string name)
    {
        _name = name;
    }

    public void Update(decimal price)
    {
        Console.WriteLine($"{_name} has been notified of the new product price: {price:C}");
    }
}
