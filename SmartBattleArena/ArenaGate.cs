using SmartBattleArena;

public class ArenaGate : IPowerable
{
    public bool IsOn { get; set; } = false;
    public void TurnOn()
    {
        IsOn = true;
    }
    public void TurnOff()
    {
        IsOn = false;
    }
}