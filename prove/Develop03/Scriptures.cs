class Scripture
{
    private Reference reference;
    private List<Word> words;

    public bool wait {get; set;}

    public Scripture(Reference reference, List<Word> words)
    {
        this.reference = reference;
        this.words = words;
    }

    public Reference Reference
    {
        get
        {
            return reference;
        }
    }

    public List<Word> Words
    {
        get
        {
            return words;
        }
    }

    public int CountWords()
    {
        int totalWords = 0;
        foreach (Word word in words)
        {
            if (word.Hidden)
            {
                totalWords += 0;
            }
            else
            {
                totalWords += 1;
            }
        }
        return totalWords;
    }

    public bool IsFullyHidden()
    {
        foreach (Word word in words)
        {
            if (!word.Hidden)
            {
                return false;
            }
            else if (wait == false)
            {
                Console.Clear();
                return true;
            }
        }
        return false;
    }

    public void HideWords(int count)
    {
        Random selectWords = new Random();
        for (int i = 0; i < count; i++)
        {
            int stringIndex = selectWords.Next(0, words.Count);
            words[stringIndex].Hidden = true;
        }
    }

    public void Display()
    {
        Console.WriteLine(Reference);
        foreach (Word word in words)
        {
            if (word.Hidden)
            {
                Console.Write("_ ");
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }
        Console.WriteLine();
    }
}