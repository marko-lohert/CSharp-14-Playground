namespace CSharp14Playground.PartialEventsAndConstructors;

public partial class StatementOfPurchase
{
    public partial StatementOfPurchase()
    {
        Console.WriteLine("Partial constructor called.");
    }

    public partial event Action PurchaseCompleted
    {
        add
        {
            Console.WriteLine("Partial event - add accessor called.");
        }
        remove
        {
            Console.WriteLine("Partial event - remove accessor called.");
        }
    }
}
