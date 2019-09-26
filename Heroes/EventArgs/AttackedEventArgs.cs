using Heros;

namespace Heroes.EventArgs
{
    public class AttackedEventArgs : System.EventArgs
    {
        public int Damage { get; set; }
        public Hero Hero { get; set; }
    }
}
