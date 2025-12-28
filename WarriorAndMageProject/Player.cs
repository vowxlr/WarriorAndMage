using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    internal abstract class Player : Character
    {
        private int playerLevel;
        private int currentExperience;
        private const int baseRequiredExperience = 100;
        private int endurance;
        private const int enduranceMultiplier = 5;

        private Inventory inventory;

        public int PlayerLevel
        {
            get
            {
                return playerLevel;
            }
        }

        public int CurrentExperience
        { 
            get
            {
                return currentExperience;
            } 
        }

        protected Player(string type, int maxHealth, int baseDamage, int endurance, string name, Inventory inventory) : base(maxHealth, baseDamage, name, type)
        {
            this.endurance = endurance;
            this.maxHealth = maxHealth + enduranceMultiplier * endurance;
            playerLevel = 1;
            currentExperience = 0;
            this.inventory = inventory;
        }

        public Player(string type, int maxHealth, int baseDamage, string name, Inventory inventory) : base(maxHealth, baseDamage, name, type)
        {
            this.type = type;
        }



        public void Healing(int additiveHealthPoints)
        {
            health = Math.Min(health + additiveHealthPoints, maxHealth);
        }
    }
}
