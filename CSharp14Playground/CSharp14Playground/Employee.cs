namespace CSharp14Playground;

public class Employee : IPerson
{
    public string FirstName { get; set; }
    public string? LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public DateOnly DateOfEmployment { get; set; }
}
