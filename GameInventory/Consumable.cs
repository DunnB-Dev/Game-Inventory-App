namespace GameInventory
{
    public class Consumable : Item
    {
        private int _healthEffect;
        private int _dosesRemaining;
        public Consumable(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
        }
    }
}
