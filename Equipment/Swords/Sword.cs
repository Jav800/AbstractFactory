namespace Equipment.Swords
{
    public abstract class Sword : Weapon
    {
        protected Sword(int Weight, int DurabiliryPerHit, int FixPosibility, int Damage) : base(Weight, DurabiliryPerHit, FixPosibility, Damage)
        {
        }
    }
}
