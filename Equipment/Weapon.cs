namespace Equipment
{
    public abstract class Weapon : Equip
    {
        protected Weapon(int Weight, int DurabiliryPerHit, int FixPosibility, int Damage) : base(Weight,DurabiliryPerHit,FixPosibility)
        {
            this.Damage = Damage;
        }
        public int Damage { get; protected set; }
        public int Durability { get; protected set; }
        public int Weight { get; protected set; }
    }
}