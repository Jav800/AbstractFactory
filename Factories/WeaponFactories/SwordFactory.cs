using Equipment.Swords;
using System;
using System.Collections.Generic;
namespace Factories.WeaponFactories
{
    internal sealed class SwordFactory : WeaponFactory
    {
        private SwordFactory()
        {
            weapons = new Dictionary<string, Type>() {
                {"WoodenSword", typeof(WoodenSword)},
                {"DrangonSword", typeof(DrangonSword)}
            };
        }
        private static SwordFactory swordFactory;
        public static SwordFactory Create()
        {
            return swordFactory ?? new SwordFactory();
        }
    }
}