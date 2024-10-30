namespace Facade_Design_Pattern;

// Step 2: Create the Facade Class

public class OrderFacade
{
    private readonly InventorySystem _inventory;
    private readonly PaymentSystem _payment;
    private readonly ShippingSystem _shipping;

    public OrderFacade()
    {
        _inventory = new InventorySystem();
        _payment = new PaymentSystem();
        _shipping = new ShippingSystem();
    }

    public void PlaceOrder(int productId, string paymentInfo, string address)
    {
        // Step 1: Check Inventory
        if (!_inventory.CheckStock(productId))
        {
            Console.WriteLine("Product is out of stock.");
            return;
        }

        // Step 2: Reserve Stock
        _inventory.ReserveStock(productId);

        // Step 3: Process Payment
        if (!_payment.ProcessPayment(paymentInfo))
        {
            Console.WriteLine("Payment failed.");
            return;
        }

        // Step 4: Ship Product
        _shipping.ShipProduct(productId, address);

        Console.WriteLine("Order placed successfully!");
    }
}
