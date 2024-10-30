namespace Pizza_Store;

public class PizzaStore
{
    public void OrderPizza(string type)
    {
        switch (type)
        {
            case "Cheese":
                var cheesePizza = new CheesePizza();
                cheesePizza.Prepare();
                cheesePizza.Bake();
                cheesePizza.Cut();
                cheesePizza.Box();
                break;
            case "Pepperoni":
                var pepperoniPizza = new PepperoniPizza();
                pepperoniPizza.Prepare();
                pepperoniPizza.Bake();
                pepperoniPizza.Cut();
                pepperoniPizza.Box();
                break;
            case "GreekPizza":
                var greekPizza = new GreekPizza();
                greekPizza.Prepare();
                greekPizza.Bake();
                greekPizza.Cut();
                greekPizza.Box();
                break;
            default:
                break;
        }

    }
    
    
}