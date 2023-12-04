namespace CH3.Solid.Dip.Correct;

public class Switch
{
    private ISwitchable device;

    public Switch(ISwitchable device)
    {
        this.device = device;
    }

    public void Toggle()
    {
        if (device.IsOn)
            device.IsOn = false;
        else
            device.IsOn = true;
    }
}
