using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Character
    {
        private int _health;
        private int _damage;
        private string _name;
        private Item[] _inventory;

        public Character()
        {
            _health = 100;
            _damage = 10;
            _name = "Player";
            _inventory = new Item[2];
        }

        public Character(int healthVal, int damageVal)
        {
            _health = healthVal;
            _damage = damageVal;
            _name = "Player";
            _inventory = new Item[2];
        }

        public virtual int Attack(Character enemy)
        {
            int damageTaken = enemy.TakeDamage(_damage);
            return damageTaken;
        }

        public int TakeDamage(int damage)
        {
            _health -= damage;
            if(_health < 0)
            {
                _health = 0;
            }
            return damage;
        }

        public void AddItemToInventory(Item item, int index)
        {
            _inventory[index] = item;
        }

        public bool GetIsAlive()
        {
            return _health > 0;
        }

        //Gets character health
        public int GetHealth()
        {
            return _health;
        }

        //Gets character damage
        public int GetDamage()
        {
            return _damage;
        }
    }
}
