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
        public string[] Abilities { get; set; }
        public int AbilityPower { get; set; }
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

        public void Attack(Champion champ, Npc npc, int flag, bool ability = false)
        {
            if (flag == 0)
            {
                if (ability)
                {
                    npc.Health = npc.Health - champ.AbilityPower;

                    System.Console.WriteLine("You dealt: " + champ.AbilityPower + "\nHis/her health is now: " + npc.Health);
                }
                else
                {
                    npc.Health = npc.Health - champ.AttackDmg;
                    System.Console.WriteLine("You dealt: " + champ.AttackDmg + "\nHis/her health is now: " + npc.Health);
                }
            }
            else if (flag == 1)
            {
                champ.Health = champ.Health - npc.AttackDmg;
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

        public void CreateChampion(string[] nameList, string[] abilities, Random rnd)
        {
            Name = nameList[rnd.Next(1, 32)];
            AttackDmg = rnd.Next(60, 100);
            Mana = rnd.Next(80, 150);
            Armor = rnd.Next(25, 50);
            Health = rnd.Next(80, 100);
            MagicResist = rnd.Next(0, 50);

            Abilities[0] = abilities[rnd.Next(0, abilities.Length)];
            Abilities[1] = abilities[rnd.Next(0, abilities.Length)];
            AbilityPower = rnd.Next(40, 70);
        }
    }
}

