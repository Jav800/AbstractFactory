using Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Factories.ArmorFactories
{
    public abstract class ArmorFactory
    {
        protected Dictionary<string, Type> armors;
        public Armor Create(string type)
        {
            if (!armors.ContainsKey(type))
                throw new ArgumentException("не существует такого типа брони");
            var constructor = armors[type]?.GetConstructors()?.FirstOrDefault((x) => x.GetParameters().Count() == 0);
            object armor = constructor?.Invoke(new object[0]);
            if (armor is Armor)
                return armor as Armor;
            return null;
        }
    }
}