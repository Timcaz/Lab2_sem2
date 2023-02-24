namespace Lab2_sem2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployeesFromDatabase();
            List<Employee> sortedSalaryEmployees = employees.OrderByDescending(e => e.Salary).ToList();

            foreach (Employee employee in sortedSalaryEmployees)
            {
                Console.WriteLine("{0} {1}: {2}", employee.FirstName, employee.LastName, employee.Salary);
            }

            static List<Employee> GetEmployeesFromDatabase(string filePath){
                // Зчитування з бази данних
            }
        }
    }
}