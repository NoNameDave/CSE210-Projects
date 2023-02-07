using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the book reference of the scripture that you would like to store (Matthew, 1 Nephi, etc.): ");
        string book = Console.ReadLine();

        Console.WriteLine("Enter the chapter reference of the scripture that you would like to store (1, 2, etc.): ");
        string chapterInput = Console.ReadLine();
        int chapter = int.Parse(chapterInput);


        Console.WriteLine("Enter the verse reference of the scripture that you would like to store (single verse(1) or multiple verses(1-5), etc.): ");
        string verseReferenceInput = Console.ReadLine();
        int verseReference = int.Parse(verseReferenceInput);

        Console.WriteLine("Enter the contents of the verse that you would like to store (I Nephi having been born, etc.): ");
        string verse = Console.ReadLine();
        

        List<Word> words = verse.Split(" ").Select(x => new Word(x)).ToList();
        Reference reference = new Reference(book,chapter,verseReference);
        Scripture scripture = new Scripture(reference, words);
        int wordsLeft = scripture.CountWords();

        do 
        {
            Console.Clear();
            scripture.Display();

            Console.Write("Press enter to hide words or type 'quit' to stop: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                Console.WriteLine("We hope to see you again soon!");
                break;                
            }
            else if (wordsLeft >= 2)
            {
                scripture.HideWords(2); 
            }                                     
        }   
        while (!scripture.IsFullyHidden());  
        Console.WriteLine("All the words have been hidden.");                
    }
}