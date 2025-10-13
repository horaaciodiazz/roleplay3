namespace Ucu.Poo.RoleplayGame;

public class DragonMaster: Villian
{
    public DragonMaster(string name) : base(name)
    {
        this.AddItem(new Shield());
        this.AddItem(new Helmet());
        this.AddItem(new Axe());
    }
    public override int Victory_Points 
    {
        get
        {
            return 3;
        }
    }
}