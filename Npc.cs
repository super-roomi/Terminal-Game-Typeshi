using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projects_and
{
    public class Npc
    {
        Champion enemy = new Champion();

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

        public Npc()
        {
            System.Console.WriteLine("NPC created!");
        }

        public void Attack()
        {
            System.Console.WriteLine("The NPC dealt: " + this.attackDmg + "\nYour health is now: " + (this.attackDmg - enemy.Health));
        }

        public void DisplayStats()
        {

            System.Console.WriteLine("Name: " + Name + "\nAttack Damage: " + AttackDmg + "\nHealth: " + Health + "\nMana: " + Mana + "\nArmor: " + Armor + "\nMagic Resist: " + MagicResist);

        }
    }
}