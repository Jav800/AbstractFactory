using Factories;

namespace Heros
{
    public class Archer : Hero
    {
        public Archer()
        {
            Name = "Лучник №1";
            HP = 80;
            abstractFactory = ArcherFactory.Create();
            Weapon = abstractFactory.CreateWeapon("PlasticBow");
            Armor = abstractFactory.CreateArmor("WoodenChainMail");
        }
    }
}