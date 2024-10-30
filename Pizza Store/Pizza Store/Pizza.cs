namespace Pizza_Store;

public abstract class Pizza
{
    protected string Name;
    protected string Dough;
    protected string Sauce;
    protected List<string> Toppings = new List<string>();

    public Pizza()
    {
    }

    public Pizza(string name, string dough, string sauce, List<string> toppings)
    {
        Name = name;
        Dough = dough;
        Sauce = sauce;
        Toppings = toppings;
    }

    public void Prepare()
    {
        Console.WriteLine("Prepare {0}", this.Name);
        Console.WriteLine("Adding Dough {0} ", this.Dough);
        Console.WriteLine("Adding Sauce {0} ", this.Sauce);
        Console.WriteLine("Adding Toppings {0} ", string.Join(", ", Toppings));
    }

    public virtual void Bake()
    {
        Console.WriteLine("Baking {0}", this.Name + " in 30p");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting {0}", this.Name);
    }

    public void Box()
    {
        Console.WriteLine("Boxing {0}", this.Name);
    }
}