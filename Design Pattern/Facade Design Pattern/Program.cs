namespace Facade_Design_Pattern;

class Program
{
    static void Main()
    {
        OrderFacade orderFacade = new OrderFacade();
        
        // Place an order using the facade
        int productId = 123;
        string paymentInfo = "CreditCard";
        string address = "123 Main St, Anytown, USA";
        
        orderFacade.PlaceOrder(productId, paymentInfo, address);
    }
}
