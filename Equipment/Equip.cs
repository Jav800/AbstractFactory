using Equipment.EventArgs;
using Equipment.EventHandlers;
namespace Equipment
{
    public abstract class Equip
    {
        public int Durability { get; protected set; }
        public int Weight { get; protected set; }
        protected int DurabiliryPerHit;
        protected int FixPosibility;
        public event UsedEventHandler Used;
        public event FixedEventHandler Fixed;
        protected Equip(int Weight, int DurabiliryPerHit, int FixPosibility)
        {
            Durability = 0;
            this.Weight = Weight;
            this.DurabiliryPerHit = DurabiliryPerHit;
            this.FixPosibility = FixPosibility;
        }
        public virtual void Fix()
        {
            var oldDurability = Durability;
            Durability = (Durability >= FixPosibility) ? Durability - FixPosibility : 0;
            Fixed?.Invoke(this, new FixedEventArgs() { Fixed = Durability - oldDurability });
        }

        public virtual void Using()
        {
            int oldDurability = Durability;
            Durability = Durability + DurabiliryPerHit < 100 ? DurabiliryPerHit + Durability : 100;
            Used?.Invoke(this, new UsedEventArgs() { Used = Durability - oldDurability });
        }
    }
}