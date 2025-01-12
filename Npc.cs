using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projects_and
{
    public class Npc
    {
        Champion champion;

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

        //For Main to create objects
        public Npc()
        {
            System.Console.WriteLine("Base NPC Created!");
        }

        //For Champion to create objects of NPC
        public Npc(Champion champion)
        {
            this.champion = champion;
        }

        public void Attack()
        {
            System.Console.WriteLine("The NPC dealt: " + this.attackDmg + "\nYour health is now: " + (this.attackDmg - champion.Health));
        }

        public void DisplayStats()
        {

            System.Console.WriteLine("Name: " + Name + "\nAttack Damage: " + AttackDmg + "\nHealth: " + Health + "\nMana: " + Mana + "\nArmor: " + Armor + "\nMagic Resist: " + MagicResist + "\n");

        }

        public void createNpc(string[] nameList, Random rnd)
        {
            Name = nameList[rnd.Next(1, 32)];
            AttackDmg = rnd.Next(0, 100);
            Mana = rnd.Next(0, 150);
            Armor = rnd.Next(0, 50);
            Health = rnd.Next(0, 100);
            MagicResist = rnd.Next(0, 50);
        }
    }
}