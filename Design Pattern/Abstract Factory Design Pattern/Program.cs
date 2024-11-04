using Abstract_Factory_Design_Pattern.AbstractFactory;
using Abstract_Factory_Design_Pattern.Factory;

namespace Abstract_Factory_Design_Pattern;

class Program
{
    static void Main(string[] args)
    {
        IAnimalFactory factory;

        Random random = new Random();
        int type = random.Next(0, 2);

        if (type == 0)
        {
            factory = new FourLegsAnimalFactory();
        }
        else
        {
            factory = new TwoLegsAnimalFactory();
        }

        Console.WriteLine(factory.CreateAnimal().GetName());
        Console.WriteLine(factory.CreateAnimal().GetName());
        Console.WriteLine(factory.CreateAnimal().GetName());
        Console.WriteLine(factory.CreateAnimal().GetName());
        Console.WriteLine(factory.CreateAnimal().GetName());
    }
}