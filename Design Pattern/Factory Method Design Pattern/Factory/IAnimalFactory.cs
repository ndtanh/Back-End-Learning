namespace Factory_Method_Design_Pattern.Factory;

using Factory_Method_Design_Pattern.Animal;

public interface IAnimalFactory
{
    IAnimal? CreateAnimal();
}