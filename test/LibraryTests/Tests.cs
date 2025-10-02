using NUnit.Framework;
using NUnit.Framework.Constraints;
using Ucu.Poo.RoleplayGame;

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
        archer.Bow = arco;
        archer.Helmet = casco;
        dwarf.Helmet = cascolol;
        dwarf.Axe = hacha;
        dwarf.Shield = escudo;
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
        libro.Spells = new Spell[]{ new Spell() };
        Staff staff = new Staff();
        Sword espada = new Sword();
        Shield escudo = new Shield();
        Armor armadura = new Armor();
        wizard.SpellsBook = libro;
        wizard.Staff = staff;
        knight.Shield = escudo;
        knight.Armor = armadura;
        knight.Sword = espada;
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