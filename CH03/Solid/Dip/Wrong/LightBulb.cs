using System;

namespace CH3.Solid.Dip.Wrong;

public class LightBulb
{
    public bool IsOn {  get; set; }

    public void TurnOn()
    {
        IsOn = true;
    }

    public void TurnOff()
    {
        IsOn = false;
    }
}
