using System.Globalization;

public class Employee
{
    public string _name { get; set; }
    public DateTime _hireDate { get; set; }
    public CalculateLeaveDays Leave { get; set; }

    public string _fileName = "employee.txt";

    public int _leaveBalance { get; set; }
    public static List<Employee> Load { get; protected set; }

    public void addEmployees()
    {
        Console.WriteLine("What is your name? ");
        _name = Console.ReadLine();
        Console.WriteLine("What is the date that you were employed? (MM/dd/yyyy) ");
        string hireDate = Console.ReadLine();
        _hireDate = DateTime.ParseExact(hireDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
    }         
public void SaveToFile(string fileName)
    {
        fileName = "employee.txt";
        List<Employee> employees = LoadFromFile(fileName);

        // update this employee's leave balance in the list
        for (int i = 0; i < employees.Count; i++)
        {
            if (employees[i]._name == _name)
            {
                employees[i]._leaveBalance = _leaveBalance;
                break;
            }
        }

        // write the updated list of employees to the file
        using (StreamWriter writer = new StreamWriter(fileName))
        {

                writer.WriteLine($"{_name},{_hireDate.ToString("yyyy-MM-dd")},{_leaveBalance}");
        }
    }

    public static List<Employee> LoadFromFile(string fileName)
    {
        fileName = "employee.txt";
        List<Employee> employees = new List<Employee>();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                Employee employee = new Employee
                {
                    _name = parts[0],
                    _hireDate = DateTime.ParseExact(parts[1], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    _leaveBalance = int.Parse(parts[2])
                };
                employees.Add(employee);
            }
        }

        return employees;
    }
}