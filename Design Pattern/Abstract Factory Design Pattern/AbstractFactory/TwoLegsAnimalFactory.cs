using Abstract_Factory_Design_Pattern.Animal;

namespace Abstract_Factory_Design_Pattern.AbstractFactory;

public class TwoLegsAnimalFactory : AbstractAnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        Random random = new Random();
        int type = random.Next(0, 2);
        if (type == 0)
        {
            return new Chicken();
        }
        else
        {
            return new Duck();
        }
    }
}