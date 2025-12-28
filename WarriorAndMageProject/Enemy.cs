using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    internal class Enemy : Character
    {
        private readonly int droppedGold;
        private readonly int droppedExperience;

        private readonly float chanceItemDrop;

        private readonly Item droppedItem;

        public Enemy(string type, int maxHealth, int baseDamage, int droppedGold, int droppedExperience, float chanceItemDrop, Item droppedItem, string name) : base(maxHealth, baseDamage, name, type)
        {
            this.droppedGold = droppedGold;
            this.droppedExperience = droppedExperience;
            this.chanceItemDrop = chanceItemDrop;
            this.droppedItem = droppedItem;
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void ApplyDamage(int damage)
        {
            base.ApplyDamage(damage);
        }
    }
}
