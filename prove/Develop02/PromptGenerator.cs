class PromptGenerator
{
    public string _prompt;

        List<string> _prompts = new List<string>{"Did you have any experience worth sharing today?", "Name one thing that made you happy.", "What emotion are you currently feeling?"};

    public PromptGenerator()
    {
        _prompt = RandomPrompt();
    }

    public string RandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return (_prompts[index]);
    }
}