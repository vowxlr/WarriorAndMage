using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    internal class Item
    {
        protected readonly int maxStack;
        protected readonly string belong;
        protected readonly string name;
        protected readonly string description;
        public string Belong
        {
            get { return belong; }
        }

        public int MaxStack
        {
            get
            {
                return maxStack;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public Item(int maxStack, string name, string description, string belong)
        {
            this.maxStack = maxStack;
            this.name = name;
            this.description = description;
            this.belong = belong;

        }
    }
}
