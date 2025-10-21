namespace CSharp14Playground.nameofUnboundGenericTypes;

public class DemoNameofUnboundGenericTypes
{
    public static void StartDemo()
    {
        PlaygroundUtils.PrintHeader("Demo: nameof unbound generic types");

        List<Employee> employees = [];

        // Before C# 14
        Console.WriteLine($"nameof: {nameof(List<Employee>)}");

        // C# 14
        Console.WriteLine($"nameof: {nameof(List<>)}");
    }
}
