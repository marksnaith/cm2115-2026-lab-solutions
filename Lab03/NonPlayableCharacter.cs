namespace Lab03;

public class NonPlayableCharacter: ICharacter
{

    private Hair hair;
    private IEyeColour eyes;
    public IOutfit Outfit {get; set;} // making this a property because it's feasible a character will want to change their outfit
    private Random random = new Random();


    public NonPlayableCharacter(Hair hair, IEyeColour eyes, IOutfit outfit)
    {
        this.hair = hair;
        this.eyes = eyes;
        this.Outfit = outfit;
    }

    public void Move()
    {
        string[] directions = {"north", "south", "east", "west"};
        string direction = directions[this.random.Next(directions.Length)];
        Console.WriteLine("Moving " + direction + ".");
    }
}
