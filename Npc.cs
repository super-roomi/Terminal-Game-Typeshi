using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projects_and
{
    public class Npc : Champion
    {
        Champion champion;

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
    }
}