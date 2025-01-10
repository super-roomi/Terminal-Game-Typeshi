using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projects_and
{
    public class Champion
    {
        Npc npc = new Npc();

        private string name;
        private int health;
        private int mana;
        private int armor;
        private int magicResist;
        private int attackDmg;

        public string Name { get => name; set => name = value; }
        public int Health { get => health; set => health = value; }
        public int Mana { get => mana; set => mana = value; }
        public int Armor { get => armor; set => armor = value; }
        public int MagicResist { get => magicResist; set => magicResist = value; }
        public int AttackDmg { get => attackDmg; set => attackDmg = value; }

        public Champion()
        {
            System.Console.WriteLine("Champion created!");

        }

        public void Attack()
        {
            System.Console.WriteLine("You dealt: " + this.attackDmg + "\nHis/her health is now: " + (this.attackDmg - (npc.Armor * 0.3) - npc.Health));
        }

        public void DisplayStats()
        {
            System.Console.WriteLine("Name: " + Name + "\nAttack Damage: " + AttackDmg + "\nHealth: " + Health + "\nMana: " + Mana + "\nArmor: " + Armor + "\nMagic Resist: " + MagicResist);
        }


    }
}

