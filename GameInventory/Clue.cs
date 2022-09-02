namespace GameInventory
{
    public class Clue : Item
    {
        private string _personIncriminated;
        private bool _accuracy;
        public Clue(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
        }
    }
}
