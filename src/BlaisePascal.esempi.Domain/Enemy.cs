using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.esempi.Domain
{
    public class Enemy
    {

        //attributo
        private int _health;
        private string _name;
        private int _level;
        private int _experience;
        private bool _isAlive;
        private int _gold;
        private int _maxHealth;

        //prprietà
        public int Health { get; private set; }
        public string Name { get; set; }
        public int Level
        {
            get
            { return _level; }

            private set
            {
                if (value <= 0)
                    throw new ArgumentException ($"Level must be greater than 0");
                _level = value;
            }

        }
        public int Experience { get; private set; }
        public int MaxHeath { get; private set; }
        public bool IsAlive { get; private set; }
        public int Gold { get; private set; }




        //costruttore
        public Enemy(string name)
        {

            _name = name;
            _level = 1;
            _experience = 0;
            _maxHealth = 100;
            Health = _maxHealth;
            _isAlive = true;
            _gold = 0;
        }

        public Enemy()
        {
            Health = 100;
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
                throw new ArgumentException("Damage cannot be negative");
            
            Health -= damage;
            
            if (Health <= 0)
                Health = 0;
        }

        public void AddExperience(int experiencePoints)
        {
            if (experiencePoints < 0)
                throw new ArgumentException("Experience points cannot be negative");
            Experience += experiencePoints;
            if (Experience < 0)
                Experience = 0;
            else if (_experience >= 100)
                _level++;
            Experience -= 100;
        }

        public void ResetExperience()
        {
            Experience = 0;
        }

        public void ResetHealth()
        {
            Health = MaxHeath;
            IsAlive = true;
        }

        public void Heal(int pointsToHeal)
        {
            if (pointsToHeal < 0)
                throw new ArgumentException(" Points to heal cannot be negative");
            Health += pointsToHeal;
            if (Health + pointsToHeal > MaxHeath)
                _health = 100;
        }

        public void AddGold(int goldToAdd)
        {
            if (goldToAdd < 0)
                throw new ArgumentException(" Gold to add cannot be negative");
            Gold += goldToAdd;
        }
    }
}
