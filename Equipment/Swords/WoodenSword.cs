namespace Equipment.Swords
{
    public class WoodenSword : Sword
    {
        public WoodenSword() : base(1,50,5,5)
        {
        }
        public override string ToString()
        {
            return "Я деревянный меч";
        }
    }
}