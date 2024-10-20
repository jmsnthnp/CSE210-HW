using System;  
using System.Collections.Generic;  

namespace MindfulnessProgram  
{  
    public class ListingActivity : Activity  
    {  
        private List<string> _prompts = new List<string>  
        {  
            "Who are people that you appreciate?",  
            "What are personal strengths of yours?",  
            "Who are people that you have helped this week?",  
            "When have you felt the Holy Ghost this month?",  
            "Who are some of your personal heroes?"  
        };  

        private HashSet<string> _usedPrompts = new HashSet<string>();  

        public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")  
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
            Console.WriteLine($"You listed {items.Count} items.");  
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
                Console.Write("Enter an item (or press Enter to finish): ");  
                string item = Console.ReadLine();  
                if (string.IsNullOrWhiteSpace(item)) break;  
                items.Add(item);  
            }  
            return items;  
        }  
    }  
}