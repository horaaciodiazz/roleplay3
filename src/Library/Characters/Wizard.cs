using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class Wizard: Character, IMagicCharacter
{
    private int health = 100;

    private List<IMagicalItem> magicalItems = new List<IMagicalItem>();

    public Wizard(string name): base(name)
    {

        this.AddItem(new Staff());
    }

    public int AttackValue
    {
        get
        {
            int value = base.AttackValue;
            foreach (IMagicalItem item in this.magicalItems)
            {
                if (item is IMagicalAttackItem)
                {
                    value += (item as IMagicalAttackItem).AttackValue;
                }
            }
            return value;
        }
    }

    public int DefenseValue
    {
        get
        {
            int value = base.DefenseValue;
            foreach (IMagicalItem item in this.magicalItems)
            {
                if (item is IMagicalDefenseItem)
                {
                    value += (item as IMagicalDefenseItem).DefenseValue;
                }
            }
            return value;
        }
    }
    public void AddItem(IMagicalItem item)
    {
        this.magicalItems.Add(item);
    }

    public void RemoveItem(IMagicalItem item)
    {
        this.magicalItems.Remove(item);
    }

}
