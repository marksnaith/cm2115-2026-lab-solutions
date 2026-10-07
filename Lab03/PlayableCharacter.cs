namespace Lab03;

public class PlayableCharacter : ICharacter
{

    private Hair hair;
    private IEyeColour eyes;
    public IOutfit Outfit {get; set;} // making this a property because it's feasible a character will want to change their outfit

    public PlayableCharacter(Hair hair, IEyeColour eyes, IOutfit outfit)
    {
        this.hair = hair;
        this.eyes = eyes;
        this.Outfit = outfit;
    }

    public void Move()
    {
        Console.Write("Which direction? ");
        string? direction = Console.ReadLine(); // the ? means that the variable *may* end up with a null value - optional but gets rid of a compiler warning
        Console.WriteLine("Moving " + direction + ".");
    }
}
