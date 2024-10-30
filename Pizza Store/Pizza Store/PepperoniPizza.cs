namespace Pizza_Store;

public class PepperoniPizza : Pizza
{
    public PepperoniPizza()
    {
        Name = "Pepperoni Pizza";
        Dough = "Thin Crust";
        Sauce = "Chilli Crust";
        Toppings = new List<string>()
        {
            "Cheese",
            "Beff"
        };
    }

    public override void Bake()
    {
        Console.WriteLine("Pepperoni Pizza is Baking.");
    }

    public PepperoniPizza(string name, string dough, string sauce, List<string> toppings) : base(name, dough, sauce, toppings)
    {
    }
}