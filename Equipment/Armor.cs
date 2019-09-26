namespace Equipment
{
    public abstract class Armor : Equip
    {
        protected Armor(int Weight, int DurabiliryPerHit, int FixPosibility, int Defence) : base(Weight, DurabiliryPerHit, FixPosibility)
        {
            this.Defence = Defence;
        }

        public int Defence { get; protected set; }
    }
}