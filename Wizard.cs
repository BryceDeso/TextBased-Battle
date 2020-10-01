﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Wizard : Character
    {
        private int _mana;

        public Wizard() : base()
        {
            _name = "Evil Wizard";
            _damage = 20;
            _mana = 100;
        }

        //This override of Attack will subtract 5 from _mana.
        public override int Attack(Character enemy)
        {
            _mana -= 5;
            return base.Attack(enemy);
        }

        //This override of PrintStats makes it print the amount left in _mana.
        public override void PrintStats(Character player)
        {
            base.PrintStats(player);
            Console.WriteLine("Mana: " + _mana);
        }
    }
}
