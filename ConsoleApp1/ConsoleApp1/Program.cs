namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list of  employees
            List<Employee> employees = new List<Employee>();
            employees
                .Add(new Employee { ID = 1, FirstName = "John", LastName = "Doe", HireDate = new DateTime(2010, 1, 1), Salary = 5000, Department = Department.IT });
            employees.Add(new Employee { ID = 2, FirstName = "Jane", LastName = "Doe", HireDate = new DateTime(2011, 1, 1), Salary = 6000, Department = Department.IT });
            employees.Add(new Employee { ID = 3, FirstName = "Jim", LastName = "Doe", HireDate = new DateTime(2012, 1, 1), Salary = 7000, Department = Department.IT });
            employees.Add(new Employee { ID = 4, FirstName = "Jill", LastName = "Doe", HireDate = new DateTime(2013, 1, 1), Salary = 8000, Department = Department.HR });
            employees.Add(new Employee { ID = 5, FirstName = "Jack", LastName = "Doe", HireDate = new DateTime(2014, 1, 1), Salary = 9000, Department = Department.HR });
            employees.Add(new Employee { ID = 6, FirstName = "Jenny", LastName = "Doe", HireDate = new DateTime(2015, 1, 1), Salary = 10000, Department = Department.IT });
            employees.Add(new Employee { ID = 7, FirstName = "Jesse", LastName = "Doe", HireDate = new DateTime(2016, 1, 1), Salary = 11000, Department = Department.IT });




            //Wie is de langst werkende werknemer?
            var longestWorkingEmployee = employees
                .OrderBy(e => e.HireDate)
                .First();
            Console.WriteLine("the  lingest  werker  is "+ longestWorkingEmployee);

            //2. Geef de drie hoogst betaalde werknemers.

            var topThreeEmployees = employees
                .OrderByDescending(e => e.Salary)
                .Take(3);
            foreach (var employee in topThreeEmployees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}, Salaris: {employee.Salary:C}");

            }

            //4. Hoeveel werknemers zijn er in de HR-afdeling?
            var hrEmployees = employees
                .Where(e => e.Department == Department.HR)
                .Count();
            Console.WriteLine($"Aantal werknemers in de HR-afdeling: {hrEmployees}");


            //list of managers
            List<Manager> managers = new List<Manager>();

            managers.Add(new Manager { Name = "John Doe", department = Department.IT, Email = "john@company.com" });
            managers.Add(new Manager { Name = "Jane Smith", department = Department.HR, Email = "jane@company.com" });
            managers.Add(new Manager { Name = "Alice Johnson", department = Department.HR, Email = "alice@company.com" });

        }
    }
}
