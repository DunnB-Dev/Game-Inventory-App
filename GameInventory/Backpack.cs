namespace GameInventory
{
    internal class Backpack
    {

        private List<Item> _contents;
        public Backpack()
        {
            _contents = new List<Item>();
        }

        public void Add(Item item)
        {
            _contents.Add(item);
        }

        public string ListWeapons()
        {
            string weapons = String.Empty;
            weapons += "\nWeapons--------------------------------------------------\n";
            foreach(Item i in _contents)
            {
                if(i is Weapon)
                {
                    weapons += i.ToString();
                    weapons += "\n---------------------------------------------------------\n";
                }
            }
            return weapons;
        }

        public string ListClues()
        {
            string clues = String.Empty;
            clues += "\nClues----------------------------------------------------\n";
            foreach(Item i in _contents)
            {
                if(i is Clue)
                {
                    clues += i.ToString();
                    clues += "\n---------------------------------------------------------\n";
                }
            }
            return clues;
        }

        public string ListConsumables()
        {
            string consumables = String.Empty;
            consumables += "\nConsumables----------------------------------------------\n";
            foreach(Item i in _contents)
            {
                if(i is Consumable)
                {
                    consumables += i.ToString();
                    consumables += "\n---------------------------------------------------------\n";
                }
            }
            return consumables;
        }
    }
}
