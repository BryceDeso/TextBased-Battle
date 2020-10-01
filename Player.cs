﻿using System;
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

        //When called, you can add an item to a selected point in the player's inventory.
        public void AddItemToInventory(Item item, int index)
        {
            _inventory[index] = item;
        }

        public Item[] GetInventory()
        {
            return _inventory;
        }

        //When called, will heal player by an item's health boost.
        public void HealPlayer(Player player, int index)
        {
            int currentHealth = player.GetHealth();
            currentHealth += _inventory[index].healthBoost;
        }

        //Sets the player's damage to a selected item in the inventory.
        public void EquipItem(Player player, int index)
        {
            player._damage = _inventory[index].damage;
        }
    }
}
