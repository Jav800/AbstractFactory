namespace Equipment.Bows
{
    public abstract class Bow : Weapon
    {
        protected Bow(int Weight, int DurabiliryPerHit, int FixPosibility, int Damage) : base(Weight,DurabiliryPerHit,FixPosibility,Damage)
        {

        }
    }
}