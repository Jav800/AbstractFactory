using Factories;

namespace Heros
{
    public class Warrior : Hero
    {
        public Warrior()
        {
            Name = "Воин №1";
            HP = 100;
            abstractFactory = WarriorFactory.Create();
            Weapon = abstractFactory.CreateWeapon("DrangonSword");
            Armor = abstractFactory.CreateArmor("LeatherCorslet");
        }
    }
}