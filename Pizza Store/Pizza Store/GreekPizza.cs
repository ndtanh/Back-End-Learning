namespace Pizza_Store;

public class GreekPizza : Pizza
{
    public GreekPizza()
    {
        Name = "Greek Pizza";
        Dough = "Big Crust";
        Sauce = "Sweet Sauce";
        Toppings = new List<string>()
        {
            "Vegetable",
            "Fruit",
        };
    }

    public override void Bake()
    {
        Console.WriteLine("Greek Pizza is being baked.");
    }

    public GreekPizza(string name, string dough, string sauce, List<string> toppings) : base(name, dough, sauce, toppings)
    {
    }
}