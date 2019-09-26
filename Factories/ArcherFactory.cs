using Equipment;
using Factories.ArmorFactories;
using Factories.WeaponFactories;

namespace Factories
{
    public class ArcherFactory : AbstractFactory
    {
        private static ArcherFactory archerFactory;
        private ArcherFactory()
        {

        }
        public static ArcherFactory Create()
        {
            if (archerFactory == null)
                archerFactory = new ArcherFactory();
            return archerFactory;

        }
        BowFactory bowFactory = BowFactory.Create();
        ChainMailFactory chainMailFactory = ChainMailFactory.Create();
        public override Armor CreateArmor(string type)
        {
            return chainMailFactory.Create(type);
        }
        public override Weapon CreateWeapon(string type)
        {
            return bowFactory.Create(type);
        }
    }
}