public class CalculateLeaveDays : Employee
{
    public List<string> CalculateAmountOfLeaveDays()
    {
        List<string> leaveDaysList = new List<string>();
        // look up the employee by name in the list
        List<Employee> employees = Employee.LoadFromFile(_fileName);

        foreach (var item in employees)
        {
            // calculate the number of months since the employee started working
            int months = (DateTime.Today.Year - item._hireDate.Year) * 12 + DateTime.Today.Month - item._hireDate.Month;

            // calculate the number of leave days accrued
            int leaveDays = (int)Math.Floor(months * 1.75);

            // add any additional leave days earned based on company policy or other factors
            // ...
            item._leaveBalance = leaveDays;

            string employeeLeave = $"{item._name} has {item._leaveBalance} leave days available.";
            leaveDaysList.Add(employeeLeave);
            item.SaveToFile(_fileName);
        }


        return leaveDaysList;
    }
}