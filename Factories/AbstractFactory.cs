using Equipment;
namespace Factories
{
    public abstract class AbstractFactory
    {
        public abstract Weapon CreateWeapon(string type);
        public abstract Armor CreateArmor(string type);
    }
}