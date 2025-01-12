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

        //Passing objects to Champion and NPC (prevent stackoverflow error)
        Champion champion = new Champion(npc);
        Npc npcc = new Npc(newchamp);

        //Choice Handling
        CenterText("Would you like to create your own champion? Or gamble to see if you have the better stats?\nType 'choose' to pick your own, anything else will be considered random");
        userChoice = Console.ReadLine();

        //Champion Creation Flow
        if (userChoice.ToLower() == "choose")
        {
            newchamp.CreateCustomChamp();
            npc.createNpc(nameList, rnd);

            System.Console.WriteLine("Your champion has the following stats:\n");
            newchamp.DisplayStats();

            System.Console.WriteLine("Your enemy has the following stats:\n");
            npc.DisplayStats();
        }
        else
        {
            //random player stats
            newchamp.CreateRandomChamp(nameList, rnd);

            npc.createNpc(nameList, rnd);

            System.Console.WriteLine("Please wait while your shahwani champion is being created");
            Console.Clear();
            LoadingAnimation(3300);

            System.Console.WriteLine("Your random champion has the following stats:");
            newchamp.DisplayStats();

            System.Console.WriteLine("Your opponent has the following stats: ");
            npc.DisplayStats();

        }

        //Actual Game Begins here
        while (newchamp.Health > 0)
        {

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
    }

    static void CenterText(string text)
    {
        // Get the terminal window width
        int windowWidth = Console.WindowWidth;

        // Calculate the starting position
        int leftPadding = (windowWidth - text.Length) / 2;

        // Ensure padding is not negative
        leftPadding = Math.Max(leftPadding, 0);

        // Print the text with padding
        Console.WriteLine(new string(' ', leftPadding) + text);
    }
}

