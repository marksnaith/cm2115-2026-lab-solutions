namespace Lab03;

public class Pet : ICharacter
{
    private IHairColour fur;

    public Pet(IHairColour fur)
    {
        this.fur = fur;
    }

    public void Move()
    {
        Console.WriteLine("The pet is moving");
    }
}
