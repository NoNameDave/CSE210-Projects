class Entry
{
    public string _prompt{get; set;}
    public string _date{get; set;}
    public string _newEntry{get; set;}

    public override string ToString()
    {
        return ($"{_date}, {_prompt}, {_newEntry}");
    }
}