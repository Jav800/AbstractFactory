namespace Equipment.ChainMails
{
    public class WoodenChainMail : ChainMail
    {
        public WoodenChainMail() : base(1,50,5,10)
        {
        }
        public override string ToString()
        {
            return "Я деревянная кольчуга";
        }
    }
}
