using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.esempi.Domain
{
    public class Enemy
    {

        //attributo
        private int _health;

        //prprietà
        public int Health { get; private set; }


        //costruttore
        public Enemy() { }

        public void setHealth(int newHealth)
        {
            if(newHealth < 0)
                _health = 0;
            else if (newHealth > 100)
                _health = 100;
            else
                _health = newHealth;
        }

        public bool isAlive()
        {
            return _health > 0; 
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentException("Damage cannot be negative");
            _health -= damage;
            if (_health < 0)
                _health = 0;
        }

    }
}
