namespace Lab03;

public class Character
{
    private IHairColour hair;
    private IEyeColour eyes;

    public Character(IHairColour hair, IEyeColour eyes)
    {
        this.hair = hair;
        this.eyes = eyes;
    }

    public void Describe()
    {
        this.hair.Describe();
        this.eyes.Describe();
    }
}
