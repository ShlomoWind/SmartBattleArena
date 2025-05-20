using SmartBattleArena;

public class BattleRobot : IPowerable, IMovable, IAttackable
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