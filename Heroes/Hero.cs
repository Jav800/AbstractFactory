using Equipment;
using Factories;
using Heroes.EventArgs;
using Heroes.EventHandlers;
namespace Heros
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int HP { get; protected set; }
        public Weapon Weapon { get; protected set; }
        public Armor Armor { get; set; }
        protected AbstractFactory abstractFactory;
        public event AttackedEventHandler Attacked;
        public event DefencedEventHandler Defenced;
        public event DeadEventHandler Dead;
        private int CountDammage(Hero hero, int damage)
        {
            if(hero.Armor.Durability<=0)
            {
                return damage;
            }
            if (hero.Armor.Defence < damage)
                return damage - hero.Armor.Defence;
            return 0;
        }
        public void Attack(Hero hero)
        {
            if (Weapon.Durability >= 100) return;
            hero.Defence(Weapon.Damage);
            Weapon.Using();
            Attacked?.Invoke(this, new AttackedEventArgs() { Hero = hero, Damage = CountDammage(hero,Weapon.Damage) });
        }
        public void Defence(int damage)
        {
            int oldHP = HP;
            if (Armor.Durability >= 100)
                HP -= damage;
            else if (Armor.Defence < damage)
                HP -= damage - Armor.Defence;
            Armor.Using();
            if(HP<=0)
            {
                Dead?.Invoke(this, new DeadEventArgs());
                return;
            }
            Defenced?.Invoke(this, new DefencedEventArgs() { Damage = oldHP - HP });
        }

        public override string ToString()
        {
            return $"\nИмя: {Name}\nXP: {HP}\nОружие: {Weapon}\nБроня: {Armor}\n";
        }
    }
}