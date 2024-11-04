namespace Abstract_Factory_Design_Pattern.Animal;

public class Duck: TwoLegsAnimal
{
    public override string GetName()
    {
        return "I'am a Duck";
    }
}