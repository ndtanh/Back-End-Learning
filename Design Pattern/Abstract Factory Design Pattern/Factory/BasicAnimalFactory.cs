using Abstract_Factory_Design_Pattern.Animal;

namespace Abstract_Factory_Design_Pattern.Factory;

public class BasicAnimalFactory : IAnimalFactory
{
    int _index = 0;
    
    public IAnimal CreateAnimal()
    {
        if(_index == 0)
        {
            _index++;
            return new Dog();
        }

        if(_index == 1)
        {
            _index++;
            return new Cat();
        }

        return null;
    }
}