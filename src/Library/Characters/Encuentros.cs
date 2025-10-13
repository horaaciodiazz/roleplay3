namespace Ucu.Poo.RoleplayGame;

public class Encuentros
{
    public List<Villian> Villians = new List<Villian>();
    public List<Heroe> Heroes = new List<Heroe>();

    public void AddVillian(Villian villian)
    {
        Villians.Add(villian);
    }
    public void AddHeroe(Heroe heroe)
    {
        Heroes.Add(heroe);
    }

    public void encuentro()
    {
        int valorV = 0;
        int valorH = 0;
        while (Heroes.Count>0&&Villians.Count>0)
        {
            foreach (var VARIABLE in Villians)
            {
                Heroes[valorH].ReceiveAttack(VARIABLE.AttackValue);
                if (Heroes[valorH].Health <= 0)
                {
                    Heroes.RemoveAt(valorH);
                }
                if (Heroes.Count() == 0)
                {
                    Console.WriteLine("Los heroes perdieron");
                    return;
                }
                valorH++;
                if (valorH > Heroes.Count - 1)
                {
                    valorH = 0;
                }
            }
            valorH = 0;
            valorV = 0;
            foreach (var VARIABLE1 in Heroes)
            {
                Villians[valorV].ReceiveAttack(VARIABLE1.AttackValue);
                if (Villians[valorV].Health <= 0)
                {
                    VARIABLE1.Victory_Points += Villians[valorV].Victory_Points;
                    Villians.RemoveAt(valorV);
                }

                if (Villians.Count() == 0)
                {
                    foreach (Heroe heroe in Heroes)
                    {
                        if (heroe.Victory_Points >= 5)
                        {
                            heroe.Cure();
                        }
                    }
                    Console.WriteLine("Los villanos perdieron");
                    return;
                }

                valorV++;
                if (valorV > Villians.Count - 1)
                {
                    valorV = 0;
                }
                
            }
        }
    }
}
