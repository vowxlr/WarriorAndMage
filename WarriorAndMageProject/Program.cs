using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon sword = new Weapon("warrior", 10, 1, "sword","оч крутой меч");
            Armor helmet = new Armor("warrior", 0, 10, "head", 1, "helmet", "cool helmet");
            Armor bodyArmor = new Armor("warrior", 0, 10, "body", 1, "body armor", "cool body armor");
            Armor gloves = new Armor("warrior", 0, 10, "hands", 1, "gloves", "cool glovest");
            Armor trousers = new Armor("warrior", 0, 10, "legs", 1, "trousers", "штаны из березовой коры");
            Armor boots = new Armor("warrior", 0, 10, "feet", 1, "boots", "cool boots");

            Weapon magicbook = new Weapon("mage", 100, 1, "Magic Book", "cool magic book");
            Armor ring = new Armor("mage", 10, 10, "ring", 1, "Ring", "cool ring");
            Armor necklace = new Armor("mage", 10, 10, "necklace", 1, "Necklace", "cool necklace");

            Inventory invMage = new Inventory();
            Mage mage = new Mage("mage", 5, 50, 100, "маг", invMage);


            Inventory invWarrior = new Inventory();
            Warrior warrior = new Warrior("warrior", 10, 10, 10, "маг", invWarrior);

            Inventory invEnemy = new Inventory();
            Enemy enemy1 = new Enemy("enemy", 5, 5, 100, 100, 75, sword ,"единственный враг");
        }
    }
}
