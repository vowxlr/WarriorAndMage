using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    internal class Armor : Item, IEquepped
    {
        private int baseDefense;
        private string type;
        private int intelligence;
        public Armor(string belong, int intelligence, int Basedefens, string Type, int maxStack, string name, string description) : base(maxStack, name, description, belong)
        {
            this.baseDefense = Basedefens;
            this.type = Type;
        }
        public string Type { get { return this.type; } }
        public int BaseDefense { get { return this.baseDefense; } }
        public int Intelligence { get { return this.intelligence; } }
    }
}
