class Word
{
    private string text;
    private bool hidden;

    public Word(string text)
    {
        this.text = text;
        this.hidden = false;
    }

    public string Text
    {
        get
        {
            return text;
        }
    }

    public bool Hidden
    {
        get
        {
            return hidden;
        }
        set
        {
            hidden = value;
        }
    }

}