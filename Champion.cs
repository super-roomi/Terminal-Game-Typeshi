using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projects_and
{
    public class Champion
    {
        Npc npc;

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

        //For main to create objects
        public Champion()
        {
            System.Console.WriteLine("Champion Created!");
            name = "idk";
        }

        //Just to get the Npc object without having infinite recursion
        public Champion(Npc npc)
        {
            this.npc = npc;
        }

        public void Attack()
        {
            System.Console.WriteLine("You dealt: " + this.attackDmg + "\nHis/her health is now: " + (this.attackDmg - (npc.Armor * 0.3) - npc.Health));
        }

        public void DisplayStats()
        {
            System.Console.WriteLine("Name: " + Name + "\nAttack Damage: " + AttackDmg + "\nHealth: " + Health + "\nMana: " + Mana + "\nArmor: " + Armor + "\nMagic Resist: " + MagicResist + "\n");
        }

        public void CreateCustomChamp()
        {
            System.Console.WriteLine("What is your champion's name?");
            Name = Console.ReadLine();

            System.Console.WriteLine("How much health does your champion have? Out of 100?");
            Health = int.Parse(Console.ReadLine());

            System.Console.WriteLine("How much attack damage does he/she deal? Out of 100?");
            AttackDmg = int.Parse(Console.ReadLine());

            System.Console.WriteLine("How much mana does he/she have? Out of 200?");
            Mana = int.Parse(Console.ReadLine());

            System.Console.WriteLine("How much armor does he/she have? Out of 50?");
            Armor = int.Parse(Console.ReadLine());

            System.Console.WriteLine("How much Magic Resist does he/she have? Out of 50?");
            MagicResist = int.Parse(Console.ReadLine());
        }

        public void CreateRandomChamp(string[] nameList, Random rnd)
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

