namespace CSharp14Playground.fieldKeyword;

public class DemoFieldKeyword
{
    public void StartDemo()
    {
        PlaygroundUtils.PrintHeader("Demo: field keyword");

        TempCelsius = -300;
        Console.WriteLine($"Temp: {TempCelsius} °C");
    }

    // Before C# 14
    /*
    private double _TempCelsius;
    public double TempCelsius
    {
        get => _TempCelsius;
        set
        {
            if (value < AbsMinTemp)
                _TempCelsius = -273.15;
            else if (value > PlanckTemperature)
                _TempCelsius = PlanckTemperature;
            else
                _TempCelsius = value;
        }
    }
    */
    
    // C# 14
    public double TempCelsius
    {
        get => field;
        set
        {
            if (value < AbsMinTemp)
                field = -273.15;
            else if (value > PlanckTemperature)
                field = PlanckTemperature;
            else
                field = value;
        }
    }

    private const double AbsMinTemp = -273.15;
    private const double PlanckTemperature = 1.41E32;
}
