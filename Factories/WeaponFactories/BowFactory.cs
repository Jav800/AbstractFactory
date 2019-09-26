using Equipment.Bows;
using System;
using System.Collections.Generic;

namespace Factories.WeaponFactories
{
    internal sealed class BowFactory : WeaponFactory
    {
        private BowFactory()
        {
            weapons = new Dictionary<string, Type>() {
            {"PlasticBow", typeof(PlasticBow)},
            {"DrangonBow", typeof(DrangonBow)}
        };
        }
        private static BowFactory bowFactory;
        public static BowFactory Create()
        {
            return bowFactory ?? new BowFactory();
        }
    }
}