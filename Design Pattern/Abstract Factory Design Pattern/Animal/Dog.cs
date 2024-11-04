namespace Abstract_Factory_Design_Pattern.Animal;

public class Dog : FourLegsAnimal
{
    public override string GetName()
    {
        return "I am Dog";
    }
}