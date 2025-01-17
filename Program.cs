namespace projects_and;

class Program
{
    static void Main(string[] args)
    {
        //greeting
        System.Console.WriteLine("Welcome to League of Better!");
        Thread.Sleep(2000);

        //variables
        string[] nameList = { "Zynera", "Kaelith", "Tharic", "Vylora", "Drevan", "Lirath", "Sylvex", "Marathis", "Tyvanna", "Kynra", "Velric", "Shyvael", "Arminth", "Zorath", "Lysara", "Eryndal", "Vexros", "Nythera", "Xalric", "Corvyn", "Myriss", "Kalthor", "Zivara", "Renyx", "Talyra", "Fyrion", "Zeryn", "Vorathis", "Quinza", "Ryvorn", "Calyx", "Nythria" };
        string[] abilities = { "Ethereal Pulse (Releases a wave of energy that damages and slows enemies)", "Spectral Slash (Slices enemies with ethereal blades, dealing magic damage)", "Blazing Strikes (Fires fiery projectiles that explode on impact)", "Phoenix Burst (Unleashes a fiery explosion around Kaelith, dealing area damage)", "Stonebreaker (Smashes the ground, dealing area damage and stunning enemies)", "Crushing Blow (Strikes with immense force, dealing physical damage and briefly knocking back enemies)", "Wailing Spirits (Summons spectral spirits that deal damage over time)", "Haunting Scream (Unleashes a scream that damages and fears enemies in a cone)", "Dark Rend (Cleave enemies, dealing physical damage and reducing their healing)", "Shadow Slash (Strikes with shadow energy, dealing bonus critical damage)", "Gale Slash (Unleashes a wind-powered slash that grows stronger with range)", "Wind Cutter (Fires a sharp wind blade that damages enemies in its path)", "Vine Grasp (Roots and damages enemies in place)", "Thorn Lash (Whips enemies with vines, dealing area damage)", "Arcane Shatter (Fires a beam of magic that explodes after a delay)", "Mystic Burst (Creates a magical explosion around the caster, damaging nearby enemies)", "Moonlit Strike (Strikes an enemy with lunar energy, dealing magic damage)", "Lunar Slash (Swipes with crescent energy, damaging enemies in an arc)", "Whispered Arrow (Fires an arrow that deals bonus damage if it hits from maximum range)", "Piercing Shot (Shoots a powerful arrow that pierces through multiple enemies)", "Infernal Blast (Launches a fiery explosion that deals area damage)", "Flame Surge (Unleashes a wave of fire that damages enemies in a line)", "Twin Fangs (Strikes twice with venomous blades, dealing poison damage)", "Serpent Bite (Deals heavy damage to poisoned enemies)", "Glacial Crush (Creates a field of ice that damages enemies over time)", "Frost Spike (Hurls an icy spear that shatters on impact, dealing area damage)", "Chaos Orb (Launches an orb that bounces between enemies, dealing magic damage)", "Disruption Strike (Strikes with chaotic energy, dealing high damage)", "Solar Flare (Calls down a ray of sunlight that damages enemies)", "Radiant Strike (Slashes with a blade of light, dealing magic damage)", "Piercing Frost (Fires a shard of ice that pierces through enemies)", "Frostbite (Strikes a single target, dealing heavy frost damage)", "Shadow Pulse (Unleashes a pulse of dark energy that damages enemies)", "Umbral Blade (Slashes with shadow energy, dealing bonus damage to low-health targets)", "Void Grasp (Pulls enemies toward you and deals magic damage)", "Void Slash (Slashes with void energy, dealing area damage)", "Crimson Blade (Deals a bleed effect to enemies)", "Blood Surge (Strikes in a cone, dealing damage based on missing health)", "Raven Swarm (Summons a flock of ravens that deal damage)", "Corrupted Talons (Sends raven claws forward, damaging enemies in a line)", "Arcane Bolts (Fires homing magic missiles at nearby enemies)", "Runic Strike (Slams the ground, releasing damaging runic energy)", "Seismic Smash (Slams the ground, sending damaging shockwaves forward)", "Earthquake Strike (Creates tremors that deal area damage)", "Spirit Lash (Whips an enemy with spectral energy, dealing damage)", "Phantom Slash (Dashes forward, striking enemies in a path)", "Electro Sphere (Throws an electric sphere that bounces between enemies)", "Static Bolt (Strikes a single target with high-voltage damage)", "Ethereal Bow (Fires a magic arrow that pierces through enemies)", "Spirit Pierce (Summons a spectral spear that damages enemies in a line)", "Flame Wave (Sends a wave of fire forward, burning enemies)", "Inferno Strike (Leaps forward, dealing area damage on impact)", "Star Lance (Throws a lance of light that explodes on impact)", "Celestial Strike (Strikes an enemy with radiant energy, dealing bonus damage)", "Void Rift (Tears open a rift that damages enemies)", "Abyssal Strike (Summons void energy to damage enemies in an area)", "Venom Spit (Sprays venom in a cone, poisoning enemies)", "Toxic Slash (Strikes an enemy, dealing bonus poison damage over time)", "Blade Cyclone (Spins, dealing damage to all nearby enemies)", "Steel Strike (Swings a heavy blade, dealing damage in a wide arc)", "Nature’s Grasp (Summons roots to entangle and damage enemies)", "Thorn Strike (Launches a projectile that damages enemies and slows them)", "Dream Shroud (Sends a wave of magical energy that damages enemies)", "Eclipse Slash (Teleports to a location and deals magic damage in an area)" };

        //objects
        Random rnd = new Random();
        Champion newchamp = new Champion();
        Npc npc = new Npc();

        //Passing objects to Champion and NPC (prevent stackoverflow error)
        Champion champion = new Champion(npc);
        Npc npcc = new Npc(newchamp);

        //assign stats
        newchamp.CreateChampion(nameList, abilities, rnd);
        npc.CreateChampion(nameList, abilities, rnd);

        System.Console.WriteLine("Please wait while your shahwani champion is being created");
        Console.Clear();
        LoadingAnimation(3300);

        System.Console.WriteLine("Your random champion has the following stats:");
        newchamp.DisplayStats();

        System.Console.WriteLine("Your opponent has the following stats: ");
        npc.DisplayStats();


        //Actual Game Begins here
        while (newchamp.Health > 0 && npc.Health > 0)
        {
            System.Console.WriteLine("Time to strike your opponent! Type STRIKE or NVM to let him/her strike first");
            string? response = Console.ReadLine();

            if (response == "STRIKE")
            {

                newchamp.Attack(newchamp, npc, flag: 0);
                response = "";
            }
            else
            {
                npc.Attack(newchamp, npc, 1);
                response = "";
            }
        }
        if (newchamp.Health < 0)
            System.Console.WriteLine("You lose!");
        else
            System.Console.WriteLine("Congratulations! You won vs: " + npc.Name);

    }

    static void LoadingAnimation(int durationMs)
    {
        char[] animationChars = new char[] { '/', '-', '\\', '|' }; // Characters for animation
        int delay = 100; // Delay in milliseconds
        int elapsed = 0; // Tracks elapsed time

        Console.Write("Loading ");

        while (elapsed < durationMs)
        {
            foreach (char c in animationChars)
            {
                if (elapsed >= durationMs)
                    break;

                Console.Write(c);
                Thread.Sleep(delay);
                elapsed += delay;
                Console.Write("\b"); // Move cursor back to overwrite the character
            }
        }

        Console.WriteLine("\nDone!");
        Console.Clear();
    }
}

