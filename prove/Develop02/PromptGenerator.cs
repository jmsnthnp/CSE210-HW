using System;  
using System.Collections.Generic;  

namespace JournalApp  
{  
    public class PromptGenerator  
    {  
        private List<string> _prompts;  

        public PromptGenerator()  
        {  
            _prompts = new List<string>  
            {  
                "Who was the most interesting person I interacted with today?",  
                "What was the best part of my day?",  
                "How did I see the hand of the Lord in my life today?",  
                "What was the strongest emotion I felt today?",  
                "If I had one thing I could do over today, what would it be?",  
                "What made you smile today?",   
                "What did you learn today?",  
                "What are you grateful for today?",  
                "How did you become productive today?" 
            };  
        }  

        private readonly Random _random = new Random();  

        public string GetRandomPrompt()  
        {  
            int index = _random.Next(_prompts.Count);  
            return _prompts[index];  
        }  
    }  
}