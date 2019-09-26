using Equipment.ChainMails;
using System;
using System.Collections.Generic;
namespace Factories.ArmorFactories
{
    internal sealed class ChainMailFactory : ArmorFactory
    {
        private ChainMailFactory()
        {
            armors = new Dictionary<string, Type>() {
            {"WoodenChainMail", typeof(WoodenChainMail)},
            {"DrangonChainMail", typeof(DrangonChainMail)}
        };
        }
        private static ChainMailFactory chainMailFactory;
        public static ChainMailFactory Create()
        {
            return chainMailFactory ?? new ChainMailFactory();
        }
    }
}