
using System;
using System.Collections.Generic;

public class PromptGenerator
{
    
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
       
        "What did I learn today?",
        "How did I help someone today?",
        "What made me laugh today?",
        "What was my biggest challenge today?",
        "What am I grateful for today?"
    };

    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
