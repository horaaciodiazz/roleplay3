using NUnit.Framework;
using NUnit.Framework.Constraints;
using Ucu.Poo.RoleplayGame;


public class TestEncuentros
{
    [Test]
    public void ArcherVSDragonMasterEncuentro()
    {
        Archer archer = new Archer("archer");
        Archer archer1 = new Archer("archer");
        DragonMaster dragonMaster = new DragonMaster("dragon master");
        Encuentros encuentro = new Encuentros();
        encuentro.AddHeroe(archer);
        encuentro.AddHeroe(archer1);
        encuentro.AddVillian(dragonMaster);
        encuentro.encuentro();
        int esperado = 93;
        Assert.That(esperado,Is.EqualTo(dragonMaster.Health));
    }
}