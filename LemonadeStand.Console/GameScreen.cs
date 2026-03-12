namespace LemonadeStand.Console;

public static class GameScreen
{
    public static void DayScreen(Player currentPlayer, GameDay today)
    {
        WriteLine("***\t***\t  ***\t  ***");
        WriteLine($"**\tDay: {currentPlayer.Day}\t\t   **");
        WriteLine($"**\tAssets: ${currentPlayer.Money:F2}\t   **");
        WriteLine("***\t***\t  ***\t  ***");
        WriteLine($"[ Weather Forecast: {today.Forecast} ]");
        WriteLine();
        Write($"How many cups of lemonade do you want to make? ");
        int cups = 0;
        while (!int.TryParse(ReadLine(), out cups))
        {
            WriteLine("Please enter a valid number:");
        }
        today.CupsMade = cups;
        Write($"How much would you like to charge per cup: $");
        decimal charge = 0;
        while (!decimal.TryParse(ReadLine(), out charge))
        {
            WriteLine("Please enter a valid number:");
        }
        today.CupsCharge = Math.Round(charge, 2, 
            MidpointRounding.AwayFromZero);
    }
}