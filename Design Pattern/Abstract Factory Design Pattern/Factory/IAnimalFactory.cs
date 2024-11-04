using Abstract_Factory_Design_Pattern.Animal;

namespace Abstract_Factory_Design_Pattern.Factory;

interface IAnimalFactory
{
    IAnimal CreateAnimal();
}