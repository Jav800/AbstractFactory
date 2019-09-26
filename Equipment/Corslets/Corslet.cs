namespace Equipment.Corslets
{
    public abstract class Corslet : Armor
    {
        protected Corslet(int Weight, int DurabiliryPerHit, int FixPosibility, int Defence) : base(Weight, DurabiliryPerHit, FixPosibility, Defence)
        {
        }
    }
}