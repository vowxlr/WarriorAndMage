using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    internal class Weapon : Item, IEquepped
    {
        private int baseDamage;
        public Weapon(string belong, int Basedamage, int maxStack, string name, string description) : base(maxStack, name, description, belong)
        {
            this.baseDamage = Basedamage;
        }
        public int BaseDamage { get { return baseDamage; } }
    }
}
