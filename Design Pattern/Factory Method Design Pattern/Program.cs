using Factory_Method_Design_Pattern.Animal;
using Factory_Method_Design_Pattern.Factory;

namespace Factory_Method_Design_Pattern;

public static class Program
{
    public static void Main()
    {
        IAnimalFactory factory;

        Random random = new Random();
        int type = random.Next(0, 2);

        if(type == 0)
        {
            factory = new BasicAnimalFactory();
        }
        else
        {
            factory = new RandomAnimalFactory();
        }

        Console.WriteLine(factory.CreateAnimal()?.GetName());
        Console.WriteLine(factory.CreateAnimal()?.GetName());
    }
}