namespace Ucu.Poo.RoleplayGame;

public class NoNameWarrior: Villian
{
    public NoNameWarrior(string name) : base(name)
    {
        this.AddItem(new Sword());
        this.AddItem(new Shield());
    }
    public override int Victory_Points 
    {
        get
        {
            return 2;
        }
    }
}