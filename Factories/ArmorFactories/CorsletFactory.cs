using Equipment.Corslets;
using Factories.ArmorFactories;
using System;
using System.Collections.Generic;

namespace Factories.ArmorFactories
{
    internal sealed class CorsletFactory : ArmorFactory
    {
        private CorsletFactory()
        {
            armors = new Dictionary<string, Type>() {
            {"LeatherCorslet", typeof(LeatherCorslet)},
            {"DrangonCorslet", typeof(DrangonCorslet)}
        };
        }
        private static CorsletFactory corsletFactory;
        public static CorsletFactory Create()
        {
            return corsletFactory ?? new CorsletFactory();
        }
    }
}