namespace Equipment.Bows
{
    public class PlasticBow : Bow
    {
        public PlasticBow() : base(1,50,5,5)
        {
            Damage = 10;
            Durability = 0;
            Weight = 1;
        }
        public override string ToString()
        {
            return "Я пластиковый лук";
        }
    }
}