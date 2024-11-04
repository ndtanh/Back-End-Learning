using Abstract_Factory_Design_Pattern.Animal;

namespace Abstract_Factory_Design_Pattern.Factory;

public class RandomAnimalFactory : IAnimalFactory
{
    public IAnimal? CreateAnimal()
    {
        Random random = new Random();
        int type = random.Next(0, 3);
        if (type == 0)
        {
            return new Dog();
        }
        else
        {
            return new Cat();
        }
    }
}