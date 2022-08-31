using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
