class Reference
{
    private string book;
    private int chapter;
    public int firstVerse;
    private int lastVerse;

    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.firstVerse = verse;
        this.lastVerse = verse;
    }

    public string Book
    {
        get
        {
            return book;
        }
    }
    public int Chapter
    {
        get
        {
            return chapter;
        }
    }
    public int FirstVerse
    {
        get
        {
            return firstVerse;
        }
    }

    public int LastVerse
    {
        get
        {
            return lastVerse;
        }
    }

    public override string ToString()
    {
        if (firstVerse == lastVerse)
        {
            return $"{Book} {Chapter}:{FirstVerse}";
        }
        else
        {
            return $"{Book} {Chapter}:{FirstVerse}-{LastVerse}";
        }
    }
}