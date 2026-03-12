namespace LemonadeStand.Console;

public class GameDay
{
    public GameDay()
    {
        Weather = GenerateWeather();
        Forecast = GenerateForecast();
        BaseCustomers = GetBaseCustomers(Weather);
    }
    
    public string Forecast { get; private set; } = String.Empty;
    public string Weather { get; private set; } =  String.Empty;
    public int BaseCustomers { get; private set; } = 0;
    public string Event { get; private set; } = String.Empty;
    public int CupsMade { get; set; } = 0;
    public decimal CupsCharge { get; set; } = 0;

    private string GenerateWeather()
    {
        return "Sunny";
    }

    private string GenerateForecast()
    {
        return "Cloudy";
    }
    
    private int GetBaseCustomers(string weather)
    {
        int result = 0;
        switch (weather)
        {
            case "Hot & Dry":
                result = 50;
                break;
            case "Sunny":
                result = 30;
                break;
            case "Cloudy":
                result = 10;
                break;
            default:
                result = 0;
                break;
        }
        return result;
    }
}