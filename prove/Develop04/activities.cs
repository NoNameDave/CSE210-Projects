public class Activities{
    public string _paragraph;

    public string GetParagraph()
    {
        return _paragraph;
    }

    public void SetParagraph(string paragraph)
    {
        _paragraph = paragraph;
    }

    public string Animation(int seconds, int milliseconds)
    {
        string[] spinner = {"/","-","\\","|","\b \b"};
        // string[] timer = {"5","4","3","2","1"};
        int i = 0;
        DateTime startTime = DateTime.Now;
        TimeSpan duration = new TimeSpan(0,0,seconds);
        while (DateTime.Now - startTime < duration)
        {
            // Console.Write("\r" + spinner[i] +" "+timer[i]);
            Console.Write("\r" + spinner[i]);
            Thread.Sleep(milliseconds);
            i = (i + 1) % spinner.Length;
            
        }
        return "";
    }

    public string Timer(int seconds, int milliseconds)
    {
        string[] timer = {"5","4","3","2","1","\b \b"};
        int i = 0;
        DateTime startTime = DateTime.Now;
        TimeSpan duration = new TimeSpan(0,0,seconds);
        while (DateTime.Now - startTime < duration)
        {
            Console.Write("\r" + timer[i]);
            Thread.Sleep(milliseconds);
            i = (i + 1) % timer.Length;
            
        }
        return "";
    }
}