using LemonadeStand.Console;

bool gameOver = false;

IntroScreen.DisplayWelcome();
Player currentPlayer = IntroScreen.CreatePlayer();

WriteLine();
WriteLine($"{currentPlayer.StandName} is now open for business!");
WriteLine($"Owned and operated by {currentPlayer.Name}!");
WriteLine();

while (!gameOver)
{
    GameDay today = new();
    GameScreen.DayScreen(currentPlayer, today);
    WriteLine();
    WriteLine($"{today.CupsMade} cups made");
    WriteLine($"${today.CupsCharge:F2} per cup.");
    gameOver = true;
}
