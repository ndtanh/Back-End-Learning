namespace Factory_Method_Design_Pattern.AbstractFactory;

using Factory_Method_Design_Pattern.Animal;
using Factory_Method_Design_Pattern.Factory;

public abstract class AbstractAnimalFactory : IAnimalFactory
{
    public IAnimal? CreateAnimal()
    {
        Random random = new Random();
        int type = random.Next(0, 2);
        if (type == 0)
        {
            return new Cat();
        }
        else
        {
            return new Dog();
        }
    }
}