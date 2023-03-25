public class LeaveTaken : Employee
{
    public void TakeLeave(int days)
    {
        if (days <= LeaveBalance)
        {
            LeaveBalance -= days;
            Console.WriteLine("{0} has taken {1} days of leave. {2} days of leave remaining.", Name, days, LeaveBalance);
        }
        else
        {
            Console.WriteLine("{0} does not have enough leave balance to take {1} days of leave.", Name, days);
        }
    }
}