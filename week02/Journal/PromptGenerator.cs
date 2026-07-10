using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public List<int> _promptsIndex = new List<int>();
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        return randomPrompt; 
    }
}