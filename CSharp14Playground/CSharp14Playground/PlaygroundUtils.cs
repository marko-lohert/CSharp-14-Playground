namespace CSharp14Playground;

public static class PlaygroundUtils
{
    public static void PrintHeader(string title, string lineElement = "-")
    {
        if (string.IsNullOrWhiteSpace(title))
            return;

        Console.WriteLine(lineElement.Multiply(title.Length));
        Console.WriteLine(title);
        Console.WriteLine(lineElement.Multiply(title.Length));
    }
}
