namespace Factory_Method_Design_Pattern.Factory;

using Factory_Method_Design_Pattern.Animal;

public class BasicAnimalFactory : IAnimalFactory
{
    int _index = 0;
    
    public IAnimal? CreateAnimal()
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