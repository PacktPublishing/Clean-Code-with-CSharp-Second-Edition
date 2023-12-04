namespace CH3.Solid.Dip.Wrong;

public class Switch
{
    private LightBulb bulb;

    public Switch(LightBulb bulb)
    {
        this.bulb = bulb;
    }

    public void Toggle()
    {
        // This high-level module depends on a low-level module directly.
        if (bulb.IsOn)
            bulb.TurnOff();
        else
            bulb.TurnOn();
    }
}
