namespace GameInventory
{
    public class Item
    {
        protected string Name;
        protected string Description;
        protected double Weight;
        protected double Value;

        public Item(string name, string description, double weight, double value)
        {
            this.Name = name;
            this.Description = description;
            this.Weight = weight;
            this.Value = value;
        }

        public override string ToString()
        {
            return $"Item name: {Name} \nDescription: {Description} \nWeight: {Weight} pounds \nValue: {Value} gold pieces";
        }
    }
}
