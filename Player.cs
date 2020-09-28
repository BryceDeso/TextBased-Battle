using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player : Character
    {
        private Item[] _inventory;

        public Player(int healthVal, int damageVal) : base(healthVal, damageVal)
        {
            _health = healthVal;
            _damage = damageVal;
            _name = "Player";
            _inventory = new Item[2];
        }

        public void AddItemToInventory(Item item, int index)
        {
            _inventory[index] = item;
        }
    }

}
