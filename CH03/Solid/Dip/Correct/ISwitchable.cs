namespace CH3.Solid.Dip.Correct;

public interface ISwitchable
{
    bool IsOn { get; set; }
    void TurnOn();
    void TurnOff();
}
