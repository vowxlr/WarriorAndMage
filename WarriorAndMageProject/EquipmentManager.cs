using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    internal class EquipmentManager
    {
        private Weapon weapon;
        private Armor armorHead;
        private Armor armorBody;
        private Armor armorHands;
        private Armor armorLegs;
        private Armor armorFeet;
        private Armor ring1;
        private Armor ring2;
        private Armor necklace;
        public EquipmentManager()
        {
            this.weapon = null;
            this.armorHead = null;
            this.armorBody = null;
            this.armorHands = null;
            this.armorLegs = null;
            this.armorFeet = null;
            this.ring1 = null;
            this.ring2 = null;
            this.necklace = null;
        }
        public int EquipWeap(Weapon weap)
        {
            if (weapon == null && weap is IEquepped)
            {
                weapon = weap;
                return weap.BaseDamage;
            }
            else
            {
                Console.WriteLine("Не удалось снарядить оружие");
                return 0;
            }
        }
        public int UnEquipWeap(Weapon weap)
        {
            if (weapon == weap)
            {
                weapon = null;
                return weap.BaseDamage;
            }
            else
            {
                Console.WriteLine("Не удалось снять оружие");
                return 0;
            }
        }
        public int EquipArmor(Armor arm)
        {
            if (arm.Type == "head" && armorHead == null)
            {
                armorHead = arm;
                return arm.BaseDefense;
            }
            if (arm.Type == "body" && armorBody == null)
            {
                armorBody = arm;
                return arm.BaseDefense;
            }
            if (arm.Type == "hands" && armorHands == null)
            {
                armorHands = arm;
                return arm.BaseDefense;
            }
            if (arm.Type == "legs" && armorLegs == null)
            {
                armorLegs = arm;
                return arm.BaseDefense;
            }
            if (arm.Type == "feet" && armorFeet == null)
            {
                armorFeet = arm;
                return arm.BaseDefense;
            }
            if (arm.Type == "ring" && ring1 == null)
            {
                ring1 = arm;
                return arm.Intelligence;
            }
            if (arm.Type == "ring" && ring2 == null)
            {
                ring2 = arm;
                return arm.Intelligence;
            }
            if (arm.Type == "necklace" && necklace == null)
            {
                necklace = arm;
                return arm.Intelligence;
            }
            else
            {
                Console.WriteLine("Не удалось экипировать броню");
                return 0;
            }
        }
        public int UnEquipArmor(Armor arm)
        {
            if (arm.Type == "head")
            {
                armorHead = null;
                return arm.BaseDefense;
            }
            if (arm.Type == "body")
            {
                armorBody = null;
                return arm.BaseDefense;
            }
            if (arm.Type == "hands")
            {
                armorHands = null;
                return arm.BaseDefense;
            }
            if (arm.Type == "legs")
            {
                armorLegs = null;
                return arm.BaseDefense;
            }
            if (arm.Type == "feet")
            {
                armorFeet = null;
                return arm.BaseDefense;
            }
            if (arm.Type == "ring")
            {
                ring1 = null;
                return arm.Intelligence;
            }
            if (arm.Type == "ring")
            {
                ring2 = null;
                return arm.Intelligence;
            }
            if (arm.Type == "necklace")
            {
                necklace = null;
                return arm.Intelligence;
            }
            else
            {
                Console.WriteLine("Не удалось снять броню");
                return 0;
            }
        }
    }
}
