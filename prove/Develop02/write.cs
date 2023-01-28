using System.IO; 

class Write
{
    public void writeJournal()
    {
        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            string text = Console.ReadLine();
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine($"{dateText}: {text}");
        }
        return;
    }
    
}