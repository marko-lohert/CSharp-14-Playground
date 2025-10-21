namespace CSharp14Playground.ExtensionMembers;

public static class DemoExtensionMembers
{
    public static void StartDemo()
    {
        PlaygroundUtils.PrintHeader("Demo: Extension Members");

        Employee newEmployee = new()
        {
            FirstName = "Mary Anne",
            LastName = "Smith",
            DateOfBirth = new DateOnly(2002, 11, 14),
            DateOfEmployment = new DateOnly(2025, 11, 11)
        };

        Console.WriteLine($"Full name: {newEmployee.FullName}");
        Console.WriteLine($"Valid employee date: {newEmployee.ValidateDateOfEmployment()}");
        Console.WriteLine($"First name has: {newEmployee.FirstName.CountWords()} words");
    }
}
