namespace CSharp14Playground.ModifiersOnSimpleLambdaParameters;

public class DemoModifiersOnSimpleLambdaParameters
{
    delegate bool SafeParse<T>(string text, out T result);

    // Before C# 14
    // SafeParse<long> strToLong = (string text, out long result) => Int64.TryParse(text, out result);

    // C# 14
    SafeParse<long> strToLong = (text, out result) => Int64.TryParse(text, out result);

    public void StartDemo()
    {
        PlaygroundUtils.PrintHeader("Demo: Modifiers on simple lambda parameters");

        Console.Write("Enter a test value: ");
        string str = Console.ReadLine() ?? string.Empty;
        strToLong(str, out long result);

        Console.WriteLine($"Result of parsing string->long: {result}");
    }
}
