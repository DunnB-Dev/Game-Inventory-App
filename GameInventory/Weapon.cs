namespace GameInventory
{
    public class Weapon:Clue
    {
        private int _damage;
        private DamageType _damageType;

        public Weapon(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
        }
    }
}
