namespace Ucu.Poo.RoleplayGame;

public class Villian: Character
{
    public Villian( string name) : base(name)
    {
        
    }
    public virtual int Victory_Points { get; }
    
}