namespace Equipment.Swords
{
    public class DrangonSword : Sword
    {
        public DrangonSword() : base(1,5,50,25)
        {
        }
        public override string ToString()
        {
            return "Я дрангон меч";
        }
    }
}