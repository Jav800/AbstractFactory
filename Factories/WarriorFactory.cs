using Equipment;
using Factories.ArmorFactories;
using Factories.WeaponFactories;

namespace Factories
{
    public class WarriorFactory : AbstractFactory
    {
        private static WarriorFactory warriorFactory;
        private WarriorFactory()
        {

        }
        public static WarriorFactory Create()
        {
            if (warriorFactory == null)
                warriorFactory = new WarriorFactory();
            return warriorFactory;

        }
        SwordFactory swordFactory = SwordFactory.Create();
        CorsletFactory corsletFactory = CorsletFactory.Create();
        public override Armor CreateArmor(string type)
        {
            return corsletFactory.Create(type);
        }
        public override Weapon CreateWeapon(string type)
        {
            return swordFactory.Create(type);
        }
    }
}