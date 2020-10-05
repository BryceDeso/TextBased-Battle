using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Character
    {
        protected int _health;
        protected int _damage;
        protected string _name;

        public Character()
        {
            _health = 100;
            _damage = 10;
            _name = "Player";
        }

        public Character(int healthVal, int damageVal)
        {
            _health = healthVal;
            _damage = damageVal;
            _name = "Player";
        }

        //Allows a character to attack another character
        public virtual int Attack(Character enemy)
        {
            int damageTaken = enemy.TakeDamage(_damage);
            return damageTaken;
        }

        //Will not allow the health to go below zero.
        public int TakeDamage(int damage)
        {
            _health -= damage;
            if (_health < 0)
            {
                _health = 0;
            }
            return damage;
        }

        //Prints character stats
        public virtual void PrintStats(Character player)
        {
            Console.WriteLine(player._name);
            Console.WriteLine("Health: " + player._health);
            Console.WriteLine("Damage: " + player._damage);
        }

        //Gets character health
        public string GetName()
        {
            return _name;
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
