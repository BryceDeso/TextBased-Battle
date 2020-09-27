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
        }

        public Character(int healthVal, int damageVal, string nameVal)
        {
            _health = healthVal;
            _damage = damageVal;
            _name = nameVal;
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
