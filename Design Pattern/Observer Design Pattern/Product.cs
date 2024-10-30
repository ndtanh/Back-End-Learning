namespace ConsoleApp1;
// Step 3: Implement the Concrete Subject

public class Product : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private decimal _price;

    public decimal Price
    {
        get { return _price; }
        set
        {
            if (_price != value)
            {
                _price = value;
                Notify();
            }
        }
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_price);
        }
    }
}
