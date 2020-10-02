using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Weapon
    {
        private int _damage;

        public Weapon(int damageVal)
        {
            _damage = damageVal;
        }

        public int GetDamage()
        {
            return _damage;
        }
    }
}
