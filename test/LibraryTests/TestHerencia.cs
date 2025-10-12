using NUnit.Framework;
using NUnit.Framework.Constraints;
using Ucu.Poo.RoleplayGame;


namespace TestLibrary;

public class Tests
{

    [Test]
    public void TestDwarfVSArcher()
    {
        Archer archer = new Archer("El goloso");
        Dwarf dwarf = new Dwarf("Torpedo");
        Bow arco = new Bow();
        Helmet casco = new Helmet();
        Axe hacha = new Axe();
        Helmet cascolol = new Helmet();
        Shield escudo = new Shield();
        archer.ReceiveAttack(dwarf.AttackValue);
        dwarf.ReceiveAttack(archer.AttackValue);
        dwarf.Cure();
        archer.Cure();
        archer.ReceiveAttack(dwarf.AttackValue);
        List<int> esperado = new List<int>() { 93, 100 };
        List<int> resultado = new List<int>() { archer.Health, dwarf.Health };
        Assert.That(esperado,Is.EqualTo(resultado));
    }

    [Test]
    public void TestWizardVSKnight()
    {
        Wizard wizard = new Wizard("Harry el sucio Potter");
        Knight knight = new Knight("CJ form Grove Street");
        SpellsBook libro = new SpellsBook();
        
        Staff staff = new Staff();
        Sword espada = new Sword();
        Shield escudo = new Shield();
        Armor armadura = new Armor();
   
        wizard.ReceiveAttack(knight.AttackValue);
        wizard.ReceiveAttack(knight.AttackValue);
        knight.ReceiveAttack(wizard.AttackValue);
        knight.ReceiveAttack(wizard.AttackValue);
        wizard.Cure();
        knight.Cure();
        knight.ReceiveAttack(wizard.AttackValue);
        knight.ReceiveAttack(wizard.AttackValue);
        List<int> esperado = new List<int>() { 100, 0 };
        List<int> resultado = new List<int>() { wizard.Health, knight.Health };
        Assert.That(esperado, Is.EqualTo(resultado));
    } 
}