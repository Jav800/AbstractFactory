namespace Equipment.Corslets
{
    public class LeatherCorslet : Corslet
    {
        public LeatherCorslet() : base(1,50,5,15)
        {
            Defence = 15;
            Durability = 0;
            Weight = 1;
        }
        public override string ToString()
        {
            return "Я кожанные латы";
        }
    }
}