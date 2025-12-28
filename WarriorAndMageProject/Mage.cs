using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    internal class Mage : Player
    {
        private int mana;
        private int intelligence;
        private const int intelligenceMultiplier = 5;
        private int defense;

        public Mage(string type, int maxHealth, int baseDamage, int intelligence, string name, Inventory inventory) : base(type, maxHealth, baseDamage, name, inventory)
        {
            mana = 0;
            this.intelligence = intelligence;
            this.baseDamage = baseDamage + intelligenceMultiplier * intelligence;
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void ApplyDamage(int damage)
        {
            throw new NotImplementedException();
        }
        public void EqupWeapon(EquipmentManager inv, Weapon weap)
        {
            if(Type == weap.Belong)
            {
                intelligence += inv.EquipWeap(weap);
            }
        }
        public void UnEqupWeapon(EquipmentManager inv, Weapon weap)
        {
            if (Type == weap.Belong)
            {
                intelligence -= inv.UnEquipWeap(weap);
            }
        }
        public void EqupArmor(EquipmentManager inv, Armor arm)
        {
            if (Type == arm.Belong)
            {
                 intelligence = inv.EquipArmor(arm);
            }
        }
        public void UnEqupArmor(EquipmentManager inv, Armor arm)
        {
            if (Type == arm.Belong)
            {
                intelligence -= inv.UnEquipArmor(arm);
            }
        }

    }
}
