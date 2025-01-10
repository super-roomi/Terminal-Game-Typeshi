namespace projects_and;

class Program
{
    static void Main(string[] args)
    {
        //variables
        bool game = true;
        string userChoice = "";
        string[] nameList = { "Zynera", "Kaelith", "Tharic", "Vylora", "Drevan", "Lirath", "Sylvex", "Marathis", "Tyvanna", "Kynra", "Velric", "Shyvael", "Arminth", "Zorath", "Lysara", "Eryndal", "Vexros", "Nythera", "Xalric", "Corvyn", "Myriss", "Kalthor", "Zivara", "Renyx", "Talyra", "Fyrion", "Zeryn", "Vorathis", "Quinza", "Ryvorn", "Calyx", "Nythria" };

        //objects
        Random rnd = new Random();
        Champion newchamp = new Champion();
        Npc npc = new Npc();

        //Choice Handling
        System.Console.WriteLine("Would you like to create your own champion? Or gamble to see if you have the better stats?\nType 'choose' to pick your own, anything else will be considered random");
        userChoice = Console.ReadLine();

        //Champion Creation
        if (userChoice.ToLower() == "choose")
        {
            System.Console.WriteLine("What is your champion's name?");
            newchamp.Name = Console.ReadLine();

            System.Console.WriteLine("How much health does your champion have? Out of 100?");
            newchamp.Health = int.Parse(Console.ReadLine());

            System.Console.WriteLine("How much attack damage does he/she deal? Out of 100?");
            newchamp.AttackDmg = int.Parse(Console.ReadLine());

            System.Console.WriteLine("How much mana does he/she have? Out of 200?");
            newchamp.Mana = int.Parse(Console.ReadLine());

            System.Console.WriteLine("How much armor does he/she have? Out of 50?");
            newchamp.Armor = int.Parse(Console.ReadLine());

            System.Console.WriteLine("How much Magic Resist does he/she have? Out of 50?");
            newchamp.MagicResist = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Your champion has the following stats:\n");
            System.Console.WriteLine("Name: " + newchamp.Name + "\nAttack Damage: " + newchamp.AttackDmg + "\nHealth: " + newchamp.Health + "\nMana: " + newchamp.Mana + "\nArmor: " + newchamp.Armor + "\nMagic Resist: " + newchamp.MagicResist);
        }
        else
        {
            //random player stats
            newchamp.Name = nameList[rnd.Next(1, 32)];
            newchamp.AttackDmg = rnd.Next(0, 100);
            newchamp.Mana = rnd.Next(0, 150);
            newchamp.Armor = rnd.Next(0, 50);
            newchamp.Health = rnd.Next(0, 100);
            newchamp.MagicResist = rnd.Next(0, 50);

            System.Console.WriteLine("Please wait while your shahwani champion is being created");
            LoadingAnimation(3300);

            System.Console.WriteLine("Your random champion has the following stats:\n");
            newchamp.DisplayStats();

            System.Console.WriteLine("Your opponent has the following stats:\n ");
            npc.DisplayStats();

        }


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
        System.Console.WriteLine("Time to play the Game!");
    }
}

