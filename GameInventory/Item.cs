using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameInventory
{
    public class Item
    {
        protected string name;
        protected string description;
        protected double weight;
        protected double value;

        public Item(string name, string description, double weight, double value)
        {
            this.name = name;
            this.description = description;
            this.weight = weight;
            this.value = value;
        }

        public override string ToString()
        {
            return $"Item name: {name} \nDescription: {description} \nWeight: {weight} pounds \nValue: {value} gold pieces";
        }
    }
}
