using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class Archer: Heroe
{
    public Archer(string name) : base(name)
    {
        this.AddItem(new Bow());
        this.AddItem(new Helmet());
    }
}
