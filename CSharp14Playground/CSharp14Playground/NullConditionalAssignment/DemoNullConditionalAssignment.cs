namespace CSharp14Playground.NullConditionalAssignment;

public static class DemoNullConditionalAssignment
{
    public static void StartDemo()
    {
        PlaygroundUtils.PrintHeader("Demo Null-conditional assignment");

        Customer newCustomer = null;

        // Before C# 14
        if (newCustomer != null)
            newCustomer.FirstName = "John";

        if (newCustomer is not null)
            newCustomer.FirstName = "John";

        if (newCustomer is { })
            newCustomer.FirstName = "John";

        // C# 14
        newCustomer?.FirstName = "John";

        Console.WriteLine($"New customer: {newCustomer?.FirstName}");

        Customer[] customers = null; // Suggested additional test: customers = [];

        // Before C# 14
        if (customers != null)
            customers[0].FirstName = "John";

        // C# 14
        customers?[0].FirstName = "John"; // Check that customers is not null.
        customers?[0]?.FirstName = "John"; // Check both that customers is not null and that it contains an item at index 0.
    }
}
