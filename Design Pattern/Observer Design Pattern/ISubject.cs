
// Step 2: Define the Subject Interface

namespace ObserverDesignPattern;

public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}