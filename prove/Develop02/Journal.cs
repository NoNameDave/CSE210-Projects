class Journal
{

    List<Entry> _entries = new List<Entry>();
    public string _fileName;

    public void AddEntry()
    {
        PromptGenerator journalPrompt = new PromptGenerator();

        string randomPrompt = journalPrompt._prompt;

        Console.WriteLine(randomPrompt);
        string _userEntry = Console.ReadLine();

        _entries.Add(new Entry() {_date = GetDate(), _prompt = randomPrompt, _newEntry = _userEntry});

        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public string GetDate()
    {
        DateTime thisDay = DateTime.Now;
        return (thisDay.ToLongDateString());
    }

    public void DisplayEntries ()
    {
        foreach (Entry _newEntry in _entries)
        {
            Console.WriteLine(_newEntry);
        }
    }

    public string LoadFile()
    {
        Console.Write("What File do you want to open? ");
        _fileName = Console.ReadLine();
        
        using (StreamReader reader = new StreamReader(_fileName))
        {
            reader.ReadToEnd();
            return _fileName;
        }
        
    }

    public void SaveEntries()
    {
        Console.Write("What would you like to name your file? ");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
}