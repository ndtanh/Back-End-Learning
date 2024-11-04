using Abstract_Factory_Design_Pattern.Animal;

namespace Abstract_Factory_Design_Pattern.AbstractFactory;

public class FourLegsAnimalFactory : AbstractAnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        Random random = new Random();
        int type = random.Next(0, 2);
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