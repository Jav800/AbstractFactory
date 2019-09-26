using System;
using System.Linq;
using System.Collections.Generic;
using Equipment;
namespace Factories.WeaponFactories
{
    internal abstract class WeaponFactory
    {
        protected Dictionary<string, Type> weapons;
        public Weapon Create(string type)
        {
            if (!weapons.ContainsKey(type))
                throw new ArgumentException("не существует такого типа оружия");
            var constructor = weapons[type]?.GetConstructors()?.FirstOrDefault((x) => x.GetParameters().Count() == 0);
            object weapon = constructor?.Invoke(new object[0]);
            if (weapon is Weapon)
                return weapon as Weapon;
            return null;
        }
    }
}