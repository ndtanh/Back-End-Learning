namespace Pizza_Store;

public class CheesePizza : Pizza
{
    public CheesePizza()
    {
        Name = "Cheese Pizza";
        Dough = "Thin";
        Sauce = "tomato sauce";
        Toppings = new List<string> {"cheese", "sauce"};
    }

    public override void Bake()
    {
        Console.WriteLine("Cheese pizza is being baked.");
    }

    public CheesePizza(string name, string dough, string sauce, List<string> toppings) : base(name, dough, sauce, toppings)
    {
 
    }
}