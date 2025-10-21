namespace CSharp14Playground;

internal class Customer : IPerson
{
    public string FirstName { get; set; }
    public string? LastName { get; set; }
    public bool HasMembershipCard { get; set; }
}
