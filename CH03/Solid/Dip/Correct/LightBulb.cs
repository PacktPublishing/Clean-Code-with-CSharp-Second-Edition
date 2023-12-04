namespace CH3.Solid.Dip.Correct;

public class LightBulb : ISwitchable
{
    public bool IsOn { get; set; }

    public void TurnOff()
    {
        IsOn = false;
    }

    public void TurnOn()
    {
        IsOn = true;
    }
}
