public class CreateGoals
{
static int GoalMenu()
        {
            Console.WriteLine("The list of goals are as follows: ");
            Console.WriteLine("1. Simple goal.");
            Console.WriteLine("2. Eternal goals.");
            Console.WriteLine("3. Checklist goals.");
            Console.Write("Select an option from the menu: ");
            string input = Console.ReadLine();
            int choice = int.Parse(input);
            return choice;
        }
}