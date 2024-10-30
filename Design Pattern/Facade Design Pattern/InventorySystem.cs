namespace Facade_Design_Pattern;
//Step 1: Define Subsystem Classes

public class InventorySystem
{
    public bool CheckStock(int productId)
    {
        Console.WriteLine("Checking stock for product " + productId);
        return true; // Assume item is always in stock for simplicity
    }

    public void ReserveStock(int productId)
    {
        Console.WriteLine("Reserving stock for product " + productId);
    }
}

public class PaymentSystem
{
    public bool ProcessPayment(string paymentInfo)
    {
        Console.WriteLine("Processing payment with info: " + paymentInfo);
        return true; // Assume payment is always successful for simplicity
    }
}

public class ShippingSystem
{
    public void ShipProduct(int productId, string address)
    {
        Console.WriteLine($"Shipping product {productId} to address {address}");
    }
}
