namespace Ucu.Poo.RoleplayGame;

public class Item
{
    public int AttackValue { get; }
    public int DefenseValue { get; }

    public Item(int attackValue, int defenseValue)
    {
        this.AttackValue = attackValue;
        this.DefenseValue = defenseValue;
    }
}