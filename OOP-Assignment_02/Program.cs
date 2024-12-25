namespace OOP_Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Hire Dates
            HireDate hireDate1 = new HireDate(15, 6, 2020);
            HireDate hireDate2 = new HireDate(1, 1, 2022);
            HireDate hireDate3 = new HireDate(12, 12, 2018);

            // Create Employees
            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(1, "John Doe", 'M', 70000, hireDate1, SecurityLevel.DBA);
            EmpArr[1] = new Employee(2, "Jane Smith", 'F', 50000, hireDate2, SecurityLevel.Guest);
            EmpArr[2] = new Employee(3, "Alice Johnson", 'F', 90000, hireDate3, SecurityLevel.Developer);

            // Display Employees
            foreach (var employee in EmpArr)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
