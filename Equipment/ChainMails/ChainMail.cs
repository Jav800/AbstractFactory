namespace Equipment.ChainMails
{
    public abstract class ChainMail : Armor
    {
        protected ChainMail(int Weight, int DurabiliryPerHit, int FixPosibility, int Defence) : base(Weight, DurabiliryPerHit, FixPosibility, Defence)
        {
        }
    }
}