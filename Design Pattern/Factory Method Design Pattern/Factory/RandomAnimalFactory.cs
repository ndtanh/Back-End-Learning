namespace Factory_Method_Design_Pattern.Factory;

using Factory_Method_Design_Pattern.Animal;

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