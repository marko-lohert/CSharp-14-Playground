namespace CSharp14Playground.ExtensionMembers;

public static class EmployeeExtensions
{
    extension(Employee employee)
    {
        public bool ValidateDateOfEmployment()
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Today);

            return employee.DateOfEmployment <= today;
        }

        public string FullName
        {
            get
            {
                return $"{employee.FirstName} {employee.LastName}";
            }
        }
    }
}
