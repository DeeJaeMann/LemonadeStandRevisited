namespace LemonadeStand.Console;

public class Player
{
    // private string _name = string.Empty;
    // private string _standName = string.Empty;
    // private decimal _money = 0;
    // private int _day = 0;

    public Player(string name, string standName)
    {
        Name = name;
        StandName = standName;
        Money = 20;
        Day = 1;
    }
    
    public string Name { get; private set; } = String.Empty;
    public string StandName { get; private set; } =  String.Empty;
    public decimal Money { get; private set; }
    public int Day { get; private set; }

    public void AddMoney(decimal money)
    {
        Money += money;
    }

    public void SubtractMoney(decimal money)
    {
        Money -= money;
    }
    
    public void IncrementDay()
    {
        Day++;
    }
}