namespace LemonadeStand.Console;

public static class IntroScreen
{
    public static void DisplayWelcome()
    {
        WriteLine("Welcome to Lemonade Stand Revisited!");
        Write("Is this your first time playing? ");
        string? firstTime = ReadLine();

        switch (firstTime)
        {
            case "y":
            case "Y":
            case "yes":
            case "Yes":
            case "YES":
                DisplayStory();
                break;
            default:
                DisplayIntro();
                break;
        }
    }
    
    static void DisplayStory()
    {
        Clear();
        WriteLine("Lemonade Stand Story");
        ReadLine();
        DisplayIntro();
    }

    static void DisplayIntro()
    {
        Clear();
        WriteLine("Start Game");
        ReadLine();
    }

    public static Player CreatePlayer()
    {
        Clear();
        string name = "";
        string standName = "";
        while (name.Length == 0)
        {
            Write("What is your name? ");
            name = ReadLine()!.Trim();
            if (name.Length == 0) WriteLine("Sorry, I didn't get that.");
        }

        while (standName.Length == 0)
        {
            Write("Choose a name for your lemonade stand: ");
            standName = ReadLine()!.Trim();
            if (standName.Length == 0) WriteLine("Sorry, I didn't get that.");
        }
        
        Player newPlayer = new(name, standName);
        return newPlayer;
    }
}