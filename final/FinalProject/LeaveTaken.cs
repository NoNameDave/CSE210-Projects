public class LeaveTaken : CalculateLeaveDays
{
    public void TakeLeave(int days)
    {
        List<Employee> employees = Employee.LoadFromFile(_fileName);

        foreach (var item in employees)
        {

                // load existing employees from file
            if (File.Exists("employee.txt"))
            {

                if (days <= item._leaveBalance)
                {
                    item._leaveBalance -= days;
                    Console.WriteLine("{0} has taken {1} days of leave. {2} days of leave remaining.", item._name, days, item._leaveBalance);
                    item.SaveToFile(_fileName);
                }
                else
                {
                    Console.WriteLine("{0} does not have enough leave balance to take {1} days of leave.", item._name, days);
                }
            }
        }
    }
}