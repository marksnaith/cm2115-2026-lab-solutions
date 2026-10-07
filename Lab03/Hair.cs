namespace Lab03;

public class Hair
{
    private IHairColour colour;
    private IHairStyle style;

    public Hair(IHairColour colour, IHairStyle style)
    {
        this.colour = colour;
        this.style = style;
    }
}
