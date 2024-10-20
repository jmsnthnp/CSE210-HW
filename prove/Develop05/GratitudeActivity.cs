using System;  
using System.Collections.Generic;  

namespace MindfulnessProgram  
{  
    public class GratitudeActivity : Activity  
    {  
        private List<string> _prompts = new List<string>  
        {  
            "What are you grateful for today?",  
            "Who has made a positive impact in your life?",  
            "What is something that made you smile this week?",  
            "What is a lesson you've learned that you're thankful for?",  
            "What is a simple pleasure you appreciate?"  
        };  

        private HashSet<string> _usedPrompts = new HashSet<string>();  

        public GratitudeActivity() : base("Gratitude Activity", "This activity will help you reflect on the things you are grateful for.")  
        {  
        }  

        public override void Run()  
        {  
            SetDuration();  
            DisplayStartingMessage();  

            string prompt = GetUniquePrompt();  
            Console.WriteLine(prompt);  
            ShowSpinner(5);  

            List<string> items = GetListFromUser();  
            Console.WriteLine($"You listed {items.Count} things you are grateful for.");  
            IncrementActivityCount();  
            DisplayEndingMessage();  
        }  

        private string GetUniquePrompt()  
        {  
            if (_usedPrompts.Count == _prompts.Count)  
            {  
                _usedPrompts.Clear(); // Reset if all prompts have been used  
            }  

            Random random = new Random();  
            string prompt;  

            do  
            {  
                prompt = _prompts[random.Next(_prompts.Count)];  
            } while (_usedPrompts.Contains(prompt));  

            _usedPrompts.Add(prompt);  
            return prompt;  
        }  

        private List<string> GetListFromUser()  
        {  
            List<string> items = new List<string>();  
            DateTime endTime = DateTime.Now.AddSeconds(_duration);  
            while (DateTime.Now < endTime)  
            {  
                Console.Write("Enter something you are grateful for (or press Enter to finish): ");  
                string item = Console.ReadLine();  
                if (string.IsNullOrWhiteSpace(item)) break;  
                items.Add(item);  
            }  
            return items;  
        }  
    }  
}