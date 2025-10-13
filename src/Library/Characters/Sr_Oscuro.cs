namespace Ucu.Poo.RoleplayGame;

public class Sr_Oscuro: Villian
{
    public Sr_Oscuro(string name) : base(name)
    {
        this.AddItem(new Sword());
        this.AddItem(new Armor());
    }

    public override int Victory_Points 
    {
        get
        {
            return 5;
        }
    }
}