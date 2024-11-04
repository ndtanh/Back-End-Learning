using Abstract_Factory_Design_Pattern.Animal;
using Abstract_Factory_Design_Pattern.Factory;

namespace Abstract_Factory_Design_Pattern.AbstractFactory;

public abstract class AbstractAnimalFactory : IAnimalFactory
{
    public abstract IAnimal CreateAnimal();
}