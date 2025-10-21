namespace CSharp14Playground.PartialEventsAndConstructors;

public static class DemoPartialEventsAndConstructors
{
    public static void StartDemo()
    {
        PlaygroundUtils.PrintHeader("Demo: Partial events and constructors");

        StatementOfPurchase statement = new StatementOfPurchase();
        statement.PurchaseCompleted += OnPurchaseCompleted;
        statement.PurchaseCompleted -= OnPurchaseCompleted;
    }

    private static void OnPurchaseCompleted()
    {
        Console.WriteLine("Purchase completed event handler called.");
    }
}
