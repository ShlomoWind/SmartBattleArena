using System;
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
    public void MoveTo(string location)
    {
        Console.WriteLine($"my location is {location}");
    }
    public int Health = 100;
    public void TakeDamage(int amount)
    {
        Health -= amount;
    }
    public void Heal(int amount)
    {
        Health += amount;
    }
}