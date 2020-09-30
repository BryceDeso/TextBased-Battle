using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Wizard : Character
    {
        private int _mana;

        public Wizard() : base()
        {
            _mana = 50;
        }

        public override int Attack(Character enemy)
        {
            
            int totalDamage = 0;
            if(_mana > 0)
            {
                _mana -= 25;
                int magicDamage = 15;
                _damage += magicDamage = totalDamage;
                return totalDamage;
            }

            totalDamage = base.Attack(enemy);
            return totalDamage;
        }

        public override void PrintStats(Character player)
        {
            base.PrintStats(player);
            Console.WriteLine("Mana: " + _mana);
        }
    }
}
