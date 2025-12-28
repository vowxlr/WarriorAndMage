using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    internal class Warrior : Player
    {
        private int rage;
        private int strength;
        private const int strengthMultiplier = 20;
        private int defense;

        public Warrior(string type, int maxHealth, int baseDamage, int strength, string name, Inventory inventory) : base(type, maxHealth, baseDamage, name, inventory)
        {
            rage = 0;
            this.strength = strength;
            this.baseDamage = baseDamage + strengthMultiplier * strength;
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
            if (Type == weap.Belong)
            {
                strength += inv.EquipWeap(weap);
            }
        }
        public void UnEqupWeapon(EquipmentManager inv, Weapon weap)
        {
            if (Type == weap.Belong)
            {
                strength -= inv.UnEquipWeap(weap);
            }
        }
        public void EqupArmor(EquipmentManager inv, Armor arm)
        {
            if (Type == arm.Belong)
            {
                defense = inv.EquipArmor(arm);
            }
        }
        public void UnEqupArmor(EquipmentManager inv, Armor arm)
        {
            if (Type == arm.Belong)
            {
                inv.UnEquipArmor(arm);
                defense = 0;
            }
        }
    }
}
