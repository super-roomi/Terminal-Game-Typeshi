using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projects_and
{
    public class Champion
    {
        Npc npc;

        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Armor { get; set; }
        public int MagicResist { get; set; }
        public int AttackDmg { get; set; }

        //For main to create objects
        public Champion()
        {
            System.Console.WriteLine("Champion Created!");
            Name = "idk";
        }

        //Just to get the Npc object without having infinite recursion
        public Champion(Npc npc)
        {
            this.npc = npc;
        }

        public void Attack(Champion champ, Npc npc, int flag)
        {
            if (flag == 0)
            {
                npc.Health = npc.Health - champ.AttackDmg;
                System.Console.WriteLine("You dealt: " + champ.AttackDmg + "\nHis/her health is now: " + npc.Health);
            }
            else if (flag == 1)
            {
                System.Console.WriteLine("The NPC dealt: " + AttackDmg + "\nYour health is now: " + (AttackDmg - Health));
            }
        }

        //Stat printing
        public void DisplayStats()
        {
            System.Console.WriteLine("Name: " + Name + "\nAttack Damage: " + AttackDmg + "\nHealth: " + Health + "\nMana: " + Mana + "\nArmor: " + Armor + "\nMagic Resist: " + MagicResist + "\n");
        }

        public void DisplayStat(string type)
        {
            if (type == "Attack")
                System.Console.WriteLine(AttackDmg);
            else if (type == "Health")
                System.Console.WriteLine(Health);
            else if (type == "Name")
                System.Console.WriteLine(Name);
        }

        //champion creation
        public void CreateCustomChamp(string[] nameList)
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
            AttackDmg = rnd.Next(60, 100);
            Mana = rnd.Next(80, 150);
            Armor = rnd.Next(25, 50);
            Health = rnd.Next(80, 100);
            MagicResist = rnd.Next(0, 50);
        }
    }
}

