using ObserverDesignPattern;

class Program
{
    static void Main()
    {
        // Create a new product
        Product product = new Product();

        // Create customers (observers)
        Customer customer1 = new Customer("Alice");
        Customer customer2 = new Customer("Bob");

        // Attach observers to the product
        product.Attach(customer1);
        product.Attach(customer2);

        // Change the product price and observe notifications
        product.Price = 29.99M; // Notifies Alice and Bob
        product.Price = 34.99M; // Notifies Alice and Bob again

        // Detach one observer and change price again
        product.Detach(customer1);
        product.Price = 39.99M; // Notifies only Bob
    }
}