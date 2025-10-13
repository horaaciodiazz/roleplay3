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
            foreach (Villian villian in Villians)
            {
                Heroes[valorH].ReceiveAttack(villian.AttackValue);
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
            foreach (Heroe heroe0 in Heroes)
            {
                Villians[valorV].ReceiveAttack(heroe0.AttackValue);
                if (Villians[valorV].Health <= 0)
                {
                    heroe0.Victory_Points += Villians[valorV].Victory_Points;
                    Villians.RemoveAt(valorV);
                }

                if (Villians.Count() == 0)
                {
                    foreach (Heroe heroe1 in Heroes)
                    {
                        if (heroe1.Victory_Points >= 5)
                        {
                            heroe1.Cure();
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
