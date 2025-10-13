using NUnit.Framework;
using NUnit.Framework.Constraints;
using Ucu.Poo.RoleplayGame;


public class TestEncuentros
{
    [Test]
    public void Archer_WizardVSDragonMaster_Sr_OscuroEncuentro()
    {
        Archer archer = new Archer("archer");
        Wizard wizard = new Wizard("wizard");
        DragonMaster dragonMaster = new DragonMaster("dragon master");
        Sr_Oscuro srOscuro = new Sr_Oscuro("dragon master");
        Encuentros encuentro = new Encuentros();
        encuentro.AddHeroe(archer);
        encuentro.AddHeroe(wizard);
        encuentro.AddVillian(dragonMaster);
        encuentro.AddVillian(srOscuro);
        encuentro.encuentro();
        int esperado = 8;
        Assert.That(esperado,Is.EqualTo(wizard.Victory_Points));
    }
    [Test]
    public void Knight_DwarfVSNoNameWarrior()
    {
        Knight knight = new Knight("knight");
        Dwarf duarf = new Dwarf("dwarf");
        NoNameWarrior noname = new NoNameWarrior("no");
        Encuentros encuentro = new Encuentros();
        encuentro.AddHeroe(knight);
        encuentro.AddHeroe(duarf);
        encuentro.AddVillian(noname);
        encuentro.encuentro();
        int esperado = 0;
        Assert.That(esperado,Is.EqualTo(encuentro.Villians.Count));
        
    }

    [Test]
    public void ArcherVSDagonMaster_NoNameWrrior()
    {
        Archer archer = new Archer("archer");
        DragonMaster dragonMaster = new DragonMaster("dragon master");
        NoNameWarrior noname = new NoNameWarrior("no");
        Encuentros encuentro = new Encuentros();
        encuentro.AddVillian(noname);
        encuentro.AddVillian(dragonMaster);
        encuentro.AddHeroe(archer);
        encuentro.encuentro();
        int esperado = 0;
        Assert.That(esperado,Is.EqualTo(encuentro.Heroes.Count));
    }
    [Test]
    public void WizardVSAllVillians()
    {
        DragonMaster dragonMaster = new DragonMaster("dragon master");
        NoNameWarrior noname = new NoNameWarrior("no");
        Sr_Oscuro srOscuro = new Sr_Oscuro("dragon master");
        Wizard wizard = new Wizard("wizard");
        Encuentros encuentro = new Encuentros();
        encuentro.AddVillian(noname);
        encuentro.AddVillian(dragonMaster);
        encuentro.AddVillian(srOscuro);
        encuentro.AddHeroe(wizard);
        encuentro.encuentro();
        int esperado = 0;
        Assert.That(esperado,Is.EqualTo(encuentro.Villians.Count));
        esperado = 10;
        Assert.That(esperado,Is.EqualTo(wizard.Victory_Points));
    }
}